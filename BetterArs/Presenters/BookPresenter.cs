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
        private readonly IBookView _view;

        private Flight _selectedFlight;

        private IMessageService _messageService;

        public BookPresenter(IBookView view, IMessageService messageService) {
            _view = view;
            _messageService = messageService;

            _view.OnPassengerIdChanged += OnPassengerIdChanged;
            _view.OnSeatClassChanged += OnSeatClassChanged;

            _view.OnCancelPressed += OnCancelPressed;

            _view.OnBookPressed += OnBookPressed;
            _view.OnBookAndContinuePressed += OnBookAndContinuePressed;
        }

        private void OnCancelPressed() {
            _view.Close();
        }

        private void OnBookAndContinuePressed() {
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

            using (ArsContext db = new ArsContext()) {
                Passenger passenger;

                db.Passengers.Load();
                db.Tickets.Load();

                if (_view.PNRFromDataBase) {
                    passenger = db.Passengers.Find(_view.PassengerId);
                } else {
                    var newPassenger = new Passenger();

                    newPassenger.FirstName = _view.PassengerName;
                    newPassenger.SurName = _view.PassengerSurname;
                    newPassenger.LastName = _view.PassengerLastName;
                    newPassenger.Phone = _view.PassengerPhone;
                    newPassenger.Email = _view.PassengerEmail;

                    passenger = db.Passengers.Add(newPassenger);
                    db.SaveChanges();

                    _view.PNRFromDataBase = true;

                    _view.SetPassengerId(passenger.Id);
                }

                var ticket = db.Tickets.Add(new Ticket() {
                    FlightId = _selectedFlight.Id,
                    PlaneSeatId = _view.SeatId,
                    PassengerId = passenger.Id,
                });

                db.SaveChanges();

                db.Invoices.Add(new Invoice() {
                    TicketId = ticket.Id,
                });

                db.SaveChanges();
            }
        }

        private void OnBookPressed() {
            OnBookAndContinuePressed();

            _view.Close();
        }

        private void OnSeatClassChanged() {
            DisplayAvailableSeats();
        }

        private void OnPassengerIdChanged() {
            Passenger passenger;

            using (ArsContext db = new ArsContext()) {
                passenger = db.Passengers.Find(_view.PassengerId);
            }

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
            using (ArsContext db = new ArsContext()) {
                _view.SeatsClassesDataSource = db.Classes.ToList();

                _view.OriginName = (from origin in db.Airports
                                    where origin.Id == _selectedFlight.OriginId
                                    select origin).First().LocalCode;

                _view.DestinationName = (from destination in db.Airports
                                         where destination.Id == _selectedFlight.DestinationId
                                         select destination).First().LocalCode;
            }

            DisplayAvailableSeats();
        }

        public void Run(int id) {
            _view.FLightId = id;

            using (ArsContext db = new ArsContext()) {
                _selectedFlight = db.Flights.Find(id);
            }

            Refresh();

            _view.Show();
        }

        private void DisplayAvailableSeats() {
            using (ArsContext db = new ArsContext()) {
                var seatsUnfiltered = (from seat in db.PlaneSeats
                                       where seat.PlaneId == _selectedFlight.PlaneId && seat.ClassId == _view.SeatClass
                                       select seat).ToList();

                _view.SeatsDataSource = (from seat in seatsUnfiltered
                                         where !db.Tickets.Any(ticket => ticket.PlaneSeatId == seat.Id && ticket.FlightId == _selectedFlight.Id)
                                         select seat).ToList();
            }
        }
    }
}
