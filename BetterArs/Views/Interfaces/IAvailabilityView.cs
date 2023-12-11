using BetterArs.Utility;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BetterArs.Views.Interfaces {
    public interface IAvailabilityView : IView {
        string OriginCode { get; set; }
        string DestinationCode { get; set; }

        string OriginAddress { get; set; }
        string DestinationAddress { get; set; }

        int Persons { get; set; }

        DateTime Date { get; set; }

        object FlightsDataSource { get; set; }
        int SelectedFlightId { get; }

        bool ShowAllButtonVisible { get; set; }

        event Action OriginCodeChanged;
        event Action DestinationCodeChanged;

        event Action OriginSelectDialogRequested;
        event Action DestinationSelectDialogRequested;

        event Action SearchButtonPressed;
        event Action BookButtonPressed;

        event Action ShowAllButtonPressed;

        event Action NewFlightButtonPressed;
        event Action EditFlightButtonPressed;
        event Action RemoveFlightButtonPressed;

        event Action ViewPlanesTable;
    }
}
