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
    public class PlanesTablePresenter : IPresenter {
        private readonly IApplicationController _controller;
        private readonly IMessageService _messageService;
        private readonly IPlanesTableView _view;

        public PlanesTablePresenter(IApplicationController controller, IPlanesTableView view, IMessageService messageService = null) {
            _controller = controller;
            _messageService = messageService;
            _view = view;

            _view.SearchButtonPressed += SearchButtonPressed;

            _view.AddButtonPressed += AddButtonPressed;
            _view.EditButtonPressed += EditButtonPressed;
            _view.RemoveButtonPressed += RemoveButtonPressed;
            _view.CopyButtonPressed += CopyButtonPressed;
        }

        private void CopyButtonPressed() {
            if (_view.SelectedPlane is null) {
                _messageService.PrintError("Необходимо сначала выбрать самолёт");

                return;
            }

            using (ArsContext db = new ArsContext()) {
                var plane = db.Planes.Find(_view.SelectedPlane.Id);

                // Enumerate all seats for this plane
                var planeSeats = from seat in db.PlaneSeats
                                 where seat.PlaneId == plane.Id
                                 select seat;

                // Create new plane
                var newPlane = db.Planes.Add(new Plane {
                    Name = plane.Name,
                });

                // Create new seats
                foreach (var seat in planeSeats) {
                    db.PlaneSeats.Add(new PlaneSeat {
                        SeatName = seat.SeatName,
                        ClassId = seat.ClassId,
                        Fare = seat.Fare,
                    });
                }

                db.SaveChanges();

                _controller.Run<EditPlanePresenter, int>(newPlane.Id);

                Refresh();
            }
        }

        private void RemoveButtonPressed() {
            if (_view.SelectedPlane is null) {
                _messageService.PrintError("Необходимо сначала выбрать самолёт");

                return;
            }

            if (!_messageService.RequestConfirmation("Удалить выбранный самолёт")) return;

            using (ArsContext db = new ArsContext()) {
                // Must not be referenced by flights
                var flights = from flight in db.Flights
                              where flight.PlaneId == _view.SelectedPlane.Id
                              select flight;

                if (flights.Any()) {
                    _messageService.PrintError($"Невозможно удалить, так как обнаружены рейсы({flights.Count()}), ссылающиеся да данный самолёт.");

                    return;
                }

                var planeToRemove = db.Planes.Find(_view.SelectedPlane.Id);

                db.Planes.Remove(planeToRemove);

                db.SaveChanges();

                Refresh();
            }
        }

        private void EditButtonPressed() {
            if (_view.SelectedPlane != null) {
                _controller.Run<EditPlanePresenter, int>(_view.SelectedPlane.Id);

                Refresh();
            }
        }

        private void AddButtonPressed() {
            using (ArsContext db = new ArsContext()) {
                var plane = db.Planes.Add(new Plane {
                    Name = "Безымянный"
                });

                db.SaveChanges();

                _controller.Run<EditPlanePresenter, int>(plane.Id);

                Refresh();
            }
        }

        private void SearchButtonPressed() {
            if (_view.PlaneName == "*") {
                Refresh();

                return;
            }

            using (ArsContext db = new ArsContext()) {
                db.PlanesView.Load();

                var planes = from plane in db.PlanesView.Local
                             where plane.Name.ToLower().StartsWith(_view.PlaneName.ToLower())
                             select plane;

                _view.Planes = planes.AsEnumerable();
            }
        }

        public void Refresh() {
            _view.PlaneName = "*";

            using (ArsContext db = new ArsContext()) {
                db.PlanesView.Load();

                _view.Planes = db.PlanesView.Local.AsEnumerable();
            }
        }

        public void Run() {
            Refresh();

            _view.Show();
        }
    }
}
