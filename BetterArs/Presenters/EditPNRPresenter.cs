using BetterArs.Model;
using BetterArs.Utility;
using BetterArs.Utility.Ioc;
using BetterArs.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterArs.Presenters {
    public class EditPNRPresenter : IPresenter<PNRView> {
        private readonly IApplicationController _controller;
        private readonly IEditPNRView _view;

        private Passenger _passenger;
        private int _ticketId;

        public EditPNRPresenter(IApplicationController controller, IEditPNRView view) {
            _controller = controller;
            _view = view;

            _view.OkButtonPressed += OkButtonPressed;
            _view.PayInvoiceButtonPressed += PayInvoiceButtonPressed;
        }

        private void PayInvoiceButtonPressed() {
            using (ArsContext db = new ArsContext()) {
                var invoices = from invoice in db.Invoices
                               where invoice.TicketId == _ticketId
                               select invoice;

                if (invoices.Any()) {
                    foreach (var invoice in invoices) {
                        invoice.IsPaid = true;
                    }

                    db.SaveChanges();

                    _view.IsInvoicePaid = true;
                }
            }
        }

        private void OkButtonPressed() {
            using (ArsContext db = new ArsContext()) {
                var passenger = db.Passengers.Find(_passenger.Id);

                passenger.FirstName = _view.FirstName;
                passenger.SurName = _view.SurName;
                passenger.LastName = _view.LastName;
                passenger.Phone = _view.Phone;
                passenger.Email = _view.Email;
                passenger.BirthDate = _view.BirthDate;

                db.SaveChanges();
            }

            _view.Close();
        }

        public void Refresh() {
            throw new NotSupportedException();
        }

        public void Run(PNRView argument) {
            using (ArsContext db = new ArsContext()) {
                _passenger = db.Passengers.Find(argument.PassengerId);

                _view.FirstName = _passenger.FirstName;
                _view.SurName = _passenger.SurName;
                _view.LastName = _passenger.LastName;

                _view.Phone = _passenger.Phone;
                _view.Email = _passenger.Email;
                _view.BirthDate = _passenger.BirthDate;

                _ticketId = argument.TicketId;
                var invoices = from invoice in db.Invoices
                               where invoice.TicketId == _ticketId
                               select invoice;

                _view.IsInvoicePaid = invoices.All(invoice => invoice.IsPaid);
            }

            _view.Show();
        }
    }
}
