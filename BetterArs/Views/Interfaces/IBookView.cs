using BetterArs.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterArs.Views.Interfaces {
    public interface IBookView : IView {
        int FLightId { set; }
        string OriginName { set; }
        string DestinationName { set; }

        // PNR
        bool PNRFromDataBase { get; set; }
        int PassengerId { get; set; }
        string PassengerSurname { get; set; }
        string PassengerName { get; set; }
        string PassengerLastName { get; set; }
        string PassengerPhone { get; set; }
        string PassengerEmail { get; set; }

        // Seats
        int SeatClass { get; }
        int SeatId { get; }

        object SeatsDataSource { get; set; }
        object SeatsClassesDataSource { get; set; }

        // Events
        event Action OnPassengerIdChanged;
        event Action OnSeatClassChanged;
        event Action OnSeatSelected;

        event Action OnCancelPressed;
        event Action OnBookAndContinuePressed;
        event Action OnBookPressed;

        void SetPassengerId(int id);
    }
}
