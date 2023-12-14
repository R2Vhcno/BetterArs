using BetterArs.Utility;
using System;

namespace BetterArs.Views.Interfaces {
    public interface IEditPNRView : IView {
        string SurName { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

        string Phone { get; set; }
        string Email { get; set; }
        DateTime BirthDate { get; set; }

        bool IsInvoicePaid { get; set; }

        event Action PayInvoiceButtonPressed;
        event Action OkButtonPressed;
    }
}
