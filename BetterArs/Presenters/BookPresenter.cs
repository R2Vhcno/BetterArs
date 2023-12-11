using BetterArs.Model;
using BetterArs.Services.Interfaces;
using BetterArs.Utility;
using BetterArs.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterArs.Presenters {
    public class BookPresenter : IPresenter<int> {
        private readonly ArsContext _arsContext;
        private readonly IBookView _view;

        private Flight _selectedFlight;

        private IMessageService _messageService;

        public BookPresenter(IBookView view, IMessageService messageService) {
            _view = view;
            _messageService = messageService;

            _arsContext = new ArsContext();

            _view.OnPassengerIdChanged += OnPassengerIdChanged;
            _view.OnSeatClassChanged += OnSeatClassChanged;

            _view.OnBookPressed += OnBookPressed;
        }

        private void OnBookPressed() {
            if (_view.SeatId == 0) {
                _messageService.PrintError("Не выбрано место");

                return;
            }

            if (_view.PassengerSurname.Length == 0) {
                _messageService.PrintError("Фамилия пассажира не может быть пустым");

                return;
            }

            if (_view.PassengerName.Length == 0) {
                _messageService.PrintError("Имя пассажира не может быть пустым");

                return;
            }

            Passenger passenger;

            if (_view.PNRFromDataBase) {
                passenger = _arsContext.Passengers.Find(_view.PassengerId);
            } else {
                var newPassenger = new Passenger();

                newPassenger.FirstName = _view.PassengerName;
                newPassenger.SurName = _view.PassengerSurname;
                newPassenger.LastName = _view.PassengerLastName;
                newPassenger.Phone = _view.PassengerPhone;
                newPassenger.Email = _view.PassengerEmail;

                passenger = _arsContext.Passengers.Add(newPassenger);
            }

            _arsContext.Tickets.Add(new Ticket() {
                FlightId = _selectedFlight.Id,
                PlaneSeatId = _view.SeatId,
                PassengerId = passenger.Id,
            });

            _arsContext.SaveChanges();
        }

        private void OnSeatClassChanged() {
            DisplayAvailableSeats();
        }

        private void OnPassengerIdChanged() {
            var passenger = _arsContext.Passengers.Find(_view.PassengerId);

            if (passenger is null) {
                _view.PNRFromDataBase = false;

                _messageService.PrintError("Запись о пассажире с таким ид не найдена");

                return;
            }

            _view.PassengerName = passenger.FirstName;
            _view.PassengerSurname = passenger.SurName;
            _view.PassengerLastName = passenger.LastName;
            _view.PassengerPhone = passenger.Phone;
            _view.PassengerEmail = passenger.Email;
        }

        public void Refresh() {
            _view.SeatsClassesDataSource = _arsContext.Classes.ToList();

            _view.OriginName = (from origin in _arsContext.Airports
                                where origin.Id == _selectedFlight.OriginId
                                select origin).First().LocalCode;

            _view.DestinationName = (from destination in _arsContext.Airports
                                     where destination.Id == _selectedFlight.DestinationId
                                     select destination).First().LocalCode;

            DisplayAvailableSeats();
        }

        public void Run(int id) {
            _view.FLightId = id;

            _selectedFlight = (from flight in _arsContext.Flights
                               where flight.Id == id
                               select flight).First();

            Refresh();

            _view.Show();
        }

        private void DisplayAvailableSeats() {
            var seatsUnfiltered = (from seat in _arsContext.PlaneSeats
                                   where seat.PlaneId == _selectedFlight.PlaneId && seat.ClassId == _view.SeatClass
                                   select seat).ToList();

            _view.SeatsDataSource = (from seat in seatsUnfiltered
                                     where !_arsContext.Tickets.Any(ticket => ticket.PlaneSeatId == seat.Id)
                                     select seat).ToList();
        }
    }
}
