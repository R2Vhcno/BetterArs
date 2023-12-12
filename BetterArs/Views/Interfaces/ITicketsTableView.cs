using BetterArs.Model;
using BetterArs.Utility;
using System;
using System.Collections.Generic;

namespace BetterArs.Views.Interfaces {
    public interface ITicketsTableView : IView {
        string PassengerName { get; set; }
        string PassengerSurname { get; set; }
        string PassengerLastname { get; set; }

        IEnumerable<PNRView> PNRs { get; set; }
        PNRView SelectedPNR { get; set; }

        event Action SearchButtonPressed;
        event Action EditButtonPressed;
        event Action DeleteButtonPressed;

        event Action CleanupButtonPressed;
    }
}
