using BetterArs.Model;
using BetterArs.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterArs.Views.Interfaces {
    public interface IEditPlaneView : IView {
        string PlaneId { get; set; }
        string PlaneName { get; set; }

        IEnumerable<PlaneSeat> PlaneSeats { get; set; }
        object Classes { get; set; }
        PlaneSeat SelectedPlaneSeat { get; }

        string PlaneSeatId { get; set; }
        string PlaneSeatName { get; set; }
        int? PlaneSeatClassId { get; set; }
        string PlaneSeatFare { get; set; }

        event Action PlaneSeatSelected;
        event Action PlaneSeatAddButtonPressed;
        event Action PlaneSeatEditButtonPressed;
        event Action PlaneSeatRemoveButtonPressed;
        event Action OkButtonPressed;

    }
}
