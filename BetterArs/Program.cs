using BetterArs.Presenters;
using BetterArs.Services;
using BetterArs.Services.Interfaces;
using BetterArs.Utility.Ioc;
using BetterArs.Utility.Ioc.Impl;
using BetterArs.Views;
using BetterArs.Views.Interfaces;
using System;
using System.Windows.Forms;

namespace BetterArs {
    internal static class Program {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new MainForm()); // Not needed in MVP

            var controller = new ApplicationController(new LightInjectAdapter())
                .RegisterView<IAvailabilityView, AvailabilityForm>()
                .RegisterView<IBookView, BookForm>()
                .RegisterView<IEditFlightView, EditFlightForm>()
                .RegisterView<ITicketsTableView, TicketsTableForm>()
                .RegisterView<IEditPNRView, EditPNRForm>()
                .RegisterService<IMessageService, MessageService>()
                .RegisterService<IAirportSelectorService, AirportSelectorService>()
                .RegisterInstance(new ApplicationContext());

            controller.Run<AvailabilityPresenter>();
        }
    }
}
