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

namespace BetterArs.Presenters {
    public class EditPlanePresenter : IPresenter<int> {
        private ArsContext _classLocalContext;
        private Plane _plane;

        private readonly IApplicationController _controller;
        private readonly IMessageService _messageService;
        private readonly IEditPlaneView _view;

        private bool _planeSeatExplicitlySelected = false;

        public EditPlanePresenter(IApplicationController controller, IEditPlaneView view, IMessageService messageService) {
            _controller = controller;
            _view = view;
            _messageService = messageService;

            _view.OkButtonPressed += OkButtonPressed;
            _view.PlaneSeatAddButtonPressed += PlaneSeatAddButtonPressed;
            _view.PlaneSeatEditButtonPressed += PlaneSeatEditButtonPressed;
            _view.PlaneSeatRemoveButtonPressed += PlaneSeatRemoveButtonPressed;
            _view.PlaneSeatSelected += PlaneSeatSelected;
        }

        private void PlaneSeatRemoveButtonPressed() {
            if (!_planeSeatExplicitlySelected || _view.SelectedPlaneSeat is null) {
                _messageService.PrintError("Сначало необходимо выбрать место.");

                return;
            }

            if (!_messageService.RequestConfirmation("Удалить выбранное место")) return;

            // Cannot remove if referenced from tickets
            var tickets = from ticket in _classLocalContext.Tickets
                          where ticket.PlaneSeatId == _view.SelectedPlaneSeat.Id
                          select ticket;

            if (tickets.Any()) {
                _messageService.PrintError("Невозможно удалить, так как на данное место оформлен билет.");

                return;
            }

            _classLocalContext.PlaneSeats.Local.Remove(_view.SelectedPlaneSeat);

            Refresh();
        }

        private void PlaneSeatEditButtonPressed() {
            if (!_planeSeatExplicitlySelected || _view.SelectedPlaneSeat is null) {
                _messageService.PrintError("Сначало необходимо выбрать место.");

                return;
            }

            // Check validity
            if (_view.PlaneSeatName.Length == 0) {
                _messageService.PrintError("Поле 'Наименование' у места не должно быть пустым.");

                return;
            }

            int classId = _view.PlaneSeatClassId ?? 0;

            if (classId == 0) {
                _messageService.PrintError("Неверный класс.");

                return;
            }

            decimal fare;
            if (!decimal.TryParse(_view.PlaneSeatFare, out fare)) {
                fare = 0;
            }

            _view.SelectedPlaneSeat.SeatName = _view.PlaneSeatName;
            _view.SelectedPlaneSeat.ClassId = classId;
            _view.SelectedPlaneSeat.Fare = fare;

            Refresh();
        }

        private void PlaneSeatSelected() {
            var seat = _view.SelectedPlaneSeat;

            if (seat is null) return;

            if (seat.Id == 0) {
                _view.PlaneSeatId = "(Ид не присвоено)";
            } else {
                _view.PlaneSeatId = seat.Id.ToString();
            }

            _view.PlaneSeatName = seat.SeatName;
            _view.PlaneSeatClassId = seat.ClassId ?? 0;
            _view.PlaneSeatFare = seat.Fare.ToString();

            _planeSeatExplicitlySelected = true;
        }

        private void PlaneSeatAddButtonPressed() {
            // Check validity

            if (_view.PlaneSeatName.Length == 0) {
                _messageService.PrintError("Поле 'Наименование' у места не должно быть пустым.");

                return;
            }

            int classId = _view.PlaneSeatClassId ?? 0;

            if (classId == 0) {
                _messageService.PrintError("Неверный класс.");

                return;
            }

            decimal fare;
            if (!decimal.TryParse(_view.PlaneSeatFare, out fare)) {
                fare = 0;
            }

            _classLocalContext.PlaneSeats.Local.Add(new PlaneSeat {
                PlaneId = _plane.Id,
                SeatName = _view.PlaneSeatName,
                ClassId = classId,
                Fare = fare
            });

            Refresh();

            _planeSeatExplicitlySelected = false;
        }

        private void OkButtonPressed() {
            _plane.Name = _view.PlaneName;

            _classLocalContext.SaveChanges();

            _view.Close();
        }

        public void Refresh() {
            var planeSeats = from planeSeat in _classLocalContext.PlaneSeats.Local
                             where planeSeat.PlaneId == _plane.Id
                             select planeSeat;

            _view.PlaneSeats = planeSeats;
        }

        public void Run(int argument) {
            // Explicitly load classes table (I dunno why they cant load int the next 'using' block)
            using (ArsContext db = new ArsContext()) {
                _view.Classes = db.Classes.ToList();
            }

            using (_classLocalContext = new ArsContext()) {
                _plane = _classLocalContext.Planes.Find(argument);

                if (_plane is null) {
                    _messageService.PrintError("Самолёт с таким Ид не найден.");

                    return;
                }

                _view.PlaneId = _plane.Id.ToString();
                _view.PlaneName = _plane.Name;

                // Load plane's seats
                _classLocalContext.PlaneSeats.Where(planeSeat => planeSeat.PlaneId == _plane.Id).Load(); // Load only neccessary seats

                Refresh();

                _view.Show();
            }
        }
    }
}
