using BetterArs.Model;
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
    public class TicketsTablePresenter : IPresenter {
        private readonly IApplicationController _controller;
        private readonly ITicketsTableView _view;

        public TicketsTablePresenter(IApplicationController controller, ITicketsTableView view) {
            _controller = controller;
            _view = view;

            _view.SearchButtonPressed += SearchButtonPressed;
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
