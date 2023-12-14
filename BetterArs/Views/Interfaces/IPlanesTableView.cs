using BetterArs.Model;
using BetterArs.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterArs.Views.Interfaces {
    public interface IPlanesTableView : IView {
        string PlaneName { get; set; }

        IEnumerable<PlaneView> Planes { get; set; }
        PlaneView SelectedPlane { get; }

        event Action SearchButtonPressed;
        event Action AddButtonPressed;
        event Action EditButtonPressed;
        event Action RemoveButtonPressed;
        event Action CopyButtonPressed;
    }
}
