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
    public class TicketsTablePresenter : IPresenter {
        private readonly IApplicationController _controller;
        private readonly IMessageService _messageService;
        private readonly ITicketsTableView _view;

        public TicketsTablePresenter(IApplicationController controller, ITicketsTableView view, IMessageService messageService = null) {
            _controller = controller;
            _view = view;
            _messageService = messageService;

            _view.SearchButtonPressed += SearchButtonPressed;
            _view.DeleteButtonPressed += DeleteButtonPressed;
            _view.CleanupButtonPressed += CleanupButtonPressed;
            _view.EditButtonPressed += EditButtonPressed;
        }

        private void EditButtonPressed() {
            if (_view.SelectedPNR is null) return;

            _controller.Run<EditPNRPresenter, PNRView>(_view.SelectedPNR);

            Refresh();
        }

        private void CleanupButtonPressed() {
            _messageService.PrintInfo("Я пока ёще не уверен, стоит ли добавлять подобный функционал, и где разместить эту кнопку");
        }

        private void DeleteButtonPressed() {
            if (!_messageService.RequestConfirmation("Удалить выбранную запись")) return;

            using (ArsContext db = new ArsContext()) {
                var ticketToRemove = db.Tickets.Find(_view.SelectedPNR.TicketId);

                if (ticketToRemove != null) {
                    db.Tickets.Remove(ticketToRemove);

                    db.SaveChanges();

                    Refresh();
                }
            }
        }

        private void SearchButtonPressed() {
            using (ArsContext db = new ArsContext()) {
                db.PNRsView.Load();

                var filteredPnrs = db.PNRsView.Local.AsEnumerable();

                if (_view.PassengerName != "*") {
                    filteredPnrs = from pnr in filteredPnrs
                                   where pnr.FirstName.ToLower().StartsWith(_view.PassengerName.ToLower())
                                   select pnr;
                }

                if (_view.PassengerSurname != "*") {
                    filteredPnrs = from pnr in filteredPnrs
                                   where pnr.SurName.ToLower().StartsWith(_view.PassengerSurname.ToLower())
                                   select pnr;
                }

                if (_view.PassengerLastname != "*") {
                    filteredPnrs = from pnr in filteredPnrs
                                   where pnr.LastName.ToLower().StartsWith(_view.PassengerLastname.ToLower())
                                   select pnr;
                }

                _view.PNRs = filteredPnrs;
            }
        }

        public void Refresh() {
            using (ArsContext db = new ArsContext()) {
                db.PNRsView.Load();

                _view.PNRs = db.PNRsView.Local.AsEnumerable();
            }
        }

        public void Run() {
            Refresh();

            _view.PassengerName = "*";
            _view.PassengerSurname = "*";
            _view.PassengerLastname = "*";

            _view.Show();
        }
    }
}
