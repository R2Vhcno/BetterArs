using BetterArs.Model;
using BetterArs.Utility;
using System;
using System.Collections.Generic;

namespace BetterArs.Views.Interfaces {
    public interface IEditFlightView : IView {
        string OriginCode { get; set; }
        string OriginAddress { get; set; }

        string DestinationCode { get; set; }
        string DestinationAddress { get; set; }

        DateTime DepartureTime { get; set; }
        TimeSpan FlightDuration { get; set; }

        IEnumerable<PlaneView> Planes { get; set; }
        PlaneView SelectedPlane { get; }
        string SelectedPlaneInfo { get; set; }

        event Action OriginCodeChanged;
        event Action DestinationCodeChanged;
        event Action SelectOriginButtonPressed;
        event Action SelectDestinationButtonPressed;

        event Action SelectPlaneButtonPressed;

        event Action OkButtonPressed;
    }
}
