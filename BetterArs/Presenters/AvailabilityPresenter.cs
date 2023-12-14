using BetterArs.Model;
using BetterArs.Services.Interfaces;
using BetterArs.Utility;
using BetterArs.Utility.Ioc;
using BetterArs.Views;
using BetterArs.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace BetterArs.Presenters {
    internal class AvailabilityPresenter : IPresenter {
        private readonly IApplicationController _controller;
        private readonly IAvailabilityView _view;

        //private readonly IMessageService _messageService;
        private readonly IAirportSelectorService _airportSelectorService;

        private BindingList<FlightView> _flightsView;

        private bool _sortByOrigin = false;
        private int _originId = 0;

        private bool _sortByDestination = false;
        private int _destinationId = 0;

        public AvailabilityPresenter(IApplicationController controller, IAvailabilityView view /*, IMessageService messageService*/, IAirportSelectorService airportSelectorService) {
            _controller = controller;
            _view = view;
            //_messageService = messageService;
            _airportSelectorService = airportSelectorService;

            _view.OriginCodeChanged += OriginCodeChanged;
            _view.OriginSelectDialogRequested += OriginSelectDialogRequested; // TODO

            _view.DestinationCodeChanged += DestinationCodeChanged;
            _view.DestinationSelectDialogRequested += DestinationSelectDialogRequested; // TODO

            _view.SearchButtonPressed += SearchButtonPressed;
            _view.BookButtonPressed += BookButtonPressed;

            _view.ShowAllButtonPressed += ShowAllButtonPressed;

            _view.NewFlightButtonPressed += NewFlightButtonPressed;
            _view.EditFlightButtonPressed += EditFlightButtonPressed;
            _view.RemoveFlightButtonPressed += RemoveFlightButtonPressed;

            _view.ViewPNRTable += ViewPNRTable;

            Refresh();
        }

        private void ViewPNRTable() {
            _controller.Run<TicketsTablePresenter>();

            Refresh();
        }

        private void EditFlightButtonPressed() {
            using (ArsContext db = new ArsContext()) {
                var flight = db.Flights.Find(_view.SelectedFlightId);

                _controller.Run<EditFlightPresenter, Flight>(flight);

                db.SaveChanges();

                Refresh();
            }
        }

        private void RemoveFlightButtonPressed() {
            using (ArsContext db = new ArsContext()) {
                var flightDoDelete = db.Flights.Find(_view.SelectedFlightId);

                // Check if there are tickets referencing flight
                var referencingTickets = from ticket in db.Tickets
                                         where ticket.FlightId == flightDoDelete.Id
                                         select ticket;

                if (referencingTickets.Any()) {
                    string ticketString = "билет";
                    int ticketCount = referencingTickets.Count();

                    if (ticketCount > 0) {
                        if (ticketCount % 10 <= 5 && (ticketCount < 10 || ticketCount >= 20) && ticketCount % 10 != 0) {
                            ticketString = "билета";
                        } else {
                            ticketString = "билетов";
                        }
                    }

                    var result = MessageBox.Show($"Для совершения этого действия, требуется удалить {ticketCount} {ticketString}, оформленных на этот рейс.",
                                    "Ошибка при удалении рейса",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                    if (result == DialogResult.Cancel) return;

                    result = MessageBox.Show("Вы уверены, что хотите удалить оформленные на этот рейс билеты?",
                                "Подтверждение действия",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (result == DialogResult.No) return;

                    foreach (var ticket in referencingTickets) {
                        db.Tickets.Remove(ticket);
                    }
                }

                db.Flights.Remove(flightDoDelete);

                db.SaveChanges();

                Refresh();
            }
        }

        private void NewFlightButtonPressed() {
            using (ArsContext db = new ArsContext()) {
                var newFlight = db.Flights.Add(new Flight() {
                    OriginId = 1,
                    DestinationId = 1,
                    DepartureTime = DateTime.Now,
                    Duration = TimeSpan.Zero,
                    PlaneId = 1
                });

                _controller.Run<EditFlightPresenter, Flight>(newFlight);

                db.SaveChanges();
            }

            Refresh();
        }

        private void ShowAllButtonPressed() {
            Refresh();
        }

        private void BookButtonPressed() {
            if (_view.SelectedFlightId == 0) {
                return;
            }

            _controller.Run<BookPresenter, int>(_view.SelectedFlightId);

            Refresh();
        }

        private void SearchButtonPressed() {
            IEnumerable<FlightView> filteredOutput = _flightsView;

            if (_sortByOrigin) {
                filteredOutput = from flight in filteredOutput
                                 where flight.OriginId == _originId
                                 select flight;
            }

            if (_sortByDestination) {
                filteredOutput = from flight in filteredOutput
                                 where flight.DestinationId == _destinationId
                                 select flight;
            }

            _view.FlightsDataSource = from flight in filteredOutput
                                      where flight.AvailableSeats >= _view.Persons && flight.DepartureTime > _view.Date
                                      select flight;

            _view.ShowAllButtonVisible = true;
        }

        private void DestinationSelectDialogRequested() {
            //throw new System.NotImplementedException();

            var airport = _airportSelectorService.SelectAirport();

            if (airport is null) { return; }

            _view.DestinationCode = airport.LocalCode;
            _view.DestinationAddress = string.Join(", ", airport.Name, airport.City);
        }

        private void DestinationCodeChanged() {
            FilterFlights();
        }

        private void OriginSelectDialogRequested() {
            //throw new System.NotImplementedException();

            var airport = _airportSelectorService.SelectAirport();

            if (airport is null) { return; }

            _view.OriginCode = airport.LocalCode;
            _view.OriginAddress = string.Join(", ", airport.Name, airport.City);
        }

        private void OriginCodeChanged() {
            FilterFlights();
        }

        private void FilterFlights() {
            if (_view.OriginCode == "*") {
                _view.OriginAddress = "Все аэропорты";

                _sortByOrigin = false;
                _originId = 0;
            }

            if (_view.DestinationCode == "*") {
                _view.DestinationAddress = "Все аэропорты";

                _sortByDestination = false;
                _destinationId = 0;
            }

            if (_view.OriginCode == "*" && _view.DestinationCode == "*") {
                return;
            }

            using (var db = new ArsContext()) {
                if (_view.OriginCode.Length == 3) {
                    var foundOrigins = from airport in db.Airports.ToList()
                                       where airport.LocalCode.StartsWith(_view.OriginCode.ToUpper())
                                       select airport;

                    if (foundOrigins.Count() == 0) {
                        _view.OriginCode = "*";
                        _view.OriginAddress = "Все аэропорты";
                    } else {
                        var origin = foundOrigins.First();

                        _view.OriginCode = origin.LocalCode;
                        _view.OriginAddress = string.Join(", ", origin.Name, origin.City);

                        _sortByOrigin = true;
                        _originId = origin.Id;
                    }
                }

                if (_view.DestinationCode.Length == 3) {
                    var foundDestinations = from airport in db.Airports.ToList()
                                            where airport.LocalCode.StartsWith(_view.DestinationCode.ToUpper())
                                            select airport;

                    if (foundDestinations.Count() == 0) {
                        _view.DestinationCode = "*";
                        _view.DestinationAddress = "Все аэропорты";
                    } else {
                        var destination = foundDestinations.First();

                        _view.DestinationCode = destination.LocalCode;
                        _view.DestinationAddress = string.Join(", ", destination.Name, destination.City);

                        _sortByDestination = true;
                        _destinationId = destination.Id;
                    }
                }
            }
        }

        public void Run() {
            _view.Show();
        }

        public void Refresh() {
            // Load data:
            using (var db = new ArsContext()) {
                db.FlightsView.Load();

                _flightsView = db.FlightsView.Local.ToBindingList();
            }

            _view.FlightsDataSource = _flightsView;

            _view.ShowAllButtonVisible = false;
        }
    }
}
