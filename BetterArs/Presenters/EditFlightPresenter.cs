using BetterArs.Model;
using BetterArs.Services.Interfaces;
using BetterArs.Utility;
using BetterArs.Utility.Ioc;
using BetterArs.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterArs.Presenters {
    public class EditFlightPresenter : IPresenter<Flight> {
        private readonly IApplicationController _controller;
        private readonly IEditFlightView _view;
        private readonly IAirportSelectorService _airportSelectorService;

        private Flight _flight;
        private Airport _originAirport;
        private Airport _destinationAirport;
        private int _planeId;

        public EditFlightPresenter(IApplicationController controller, IEditFlightView view, IAirportSelectorService airportSelectorService) {
            _controller = controller;
            _view = view;
            _airportSelectorService = airportSelectorService;

            _view.OriginCodeChanged += OriginCodeChanged;
            _view.DestinationCodeChanged += DestinationCodeChanged;

            _view.SelectOriginButtonPressed += SelectOriginButtonPressed;
            _view.SelectDestinationButtonPressed += SelectDestinationButtonPressed;

            _view.SelectPlaneButtonPressed += SelectPlaneButtonPressed;

            _view.OkButtonPressed += OkButtonPressed;
        }

        private void SelectPlaneButtonPressed() {
            _view.SelectedPlaneInfo = $"{_view.SelectedPlane.Name}, кол-во мест: {_view.SelectedPlane.AvailableSeats}";

            _planeId = _view.SelectedPlane.Id;
        }

        private void OkButtonPressed() {
            if (_originAirport.Id == _destinationAirport.Id) {
                MessageBox.Show("Аэропорт назначения совпадает с аэропортом отправления", "Совпадение точек маршрута", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            _flight.OriginId = _originAirport.Id;
            _flight.DestinationId = _destinationAirport.Id;
            _flight.PlaneId = _planeId;
            _flight.DepartureTime = _view.DepartureTime;
            _flight.Duration = _view.FlightDuration;

            _view.Close();
        }

        private void OriginCodeChanged() {
            var code = _view.OriginCode;

            if (code.Length != 3) {
                if (code.Length == 0) {
                    _view.OriginCode = _originAirport.LocalCode;
                    _view.OriginAddress = string.Join(", ", _originAirport.Name, _originAirport.City);
                }

                return;
            }

            code = code.ToLower();

            using (ArsContext db = new ArsContext()) {
                var origins = from airport in db.Airports
                              where airport.LocalCode == code
                              select airport;

                if (origins.Count()  > 0) {
                    _originAirport = origins.First();
                } 

                _view.OriginCode = _originAirport.LocalCode;
                _view.OriginAddress = string.Join(", ", _originAirport.Name, _originAirport.City);
            }
        }

        private void DestinationCodeChanged() {
            var code = _view.DestinationCode;

            if (code.Length != 3) {
                if (code.Length == 0) {
                    _view.DestinationCode = _originAirport.LocalCode;
                    _view.DestinationAddress = string.Join(", ", _originAirport.Name, _originAirport.City);
                }

                return;
            }

            code = code.ToLower();

            using (ArsContext db = new ArsContext()) {
                var origins = from airport in db.Airports
                              where airport.LocalCode == code
                              select airport;

                if (origins.Count() > 0) {
                    _destinationAirport = origins.First();
                }

                _view.DestinationCode = _destinationAirport.LocalCode;
                _view.DestinationAddress = string.Join(", ", _destinationAirport.Name, _destinationAirport.City);
            }
        }

        private void SelectOriginButtonPressed() {
            var airport = _airportSelectorService.SelectAirport();

            if (airport is null) { return; }

            _originAirport = airport;
            _view.OriginCode = airport.LocalCode;
            _view.OriginAddress = string.Join(", ", airport.Name, airport.City);
        }

        private void SelectDestinationButtonPressed() {
            var airport = _airportSelectorService.SelectAirport();

            if (airport is null) { return; }

            _destinationAirport = airport;
            _view.DestinationCode = airport.LocalCode;
            _view.DestinationAddress = string.Join(", ", airport.Name, airport.City);
        }

        public void Refresh() {
            throw new NotSupportedException();
        }

        public void Run(Flight argument) {
            _flight = argument;

            using (ArsContext db = new ArsContext()) {
                _originAirport = db.Airports.Find(_flight.OriginId);
                _destinationAirport = db.Airports.Find(_flight.DestinationId);
                _planeId = _flight.PlaneId;

                db.PlanesView.Load();
                _view.Planes = db.PlanesView.Local.AsEnumerable();

                var selectedPlane = (from plane in db.PlanesView
                                    where plane.Id == _flight.PlaneId
                                    select plane).First();
                _view.SelectedPlaneInfo = $"{selectedPlane.Name}, кол-во мест: {selectedPlane.AvailableSeats}";

                _view.OriginCode = _originAirport.LocalCode;
                _view.OriginAddress = $"{_originAirport.Name}, {_originAirport.City}";

                _view.DestinationCode = _destinationAirport.LocalCode;
                _view.DestinationAddress = $"{_destinationAirport.Name}, {_destinationAirport.City}";

                _view.DepartureTime = _flight.DepartureTime;
                _view.FlightDuration = _flight.Duration;

                _view.Show();
            }
        }
    }
}
