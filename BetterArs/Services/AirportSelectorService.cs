using BetterArs.Model;
using BetterArs.Services.Interfaces;
using BetterArs.Views;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterArs.Services {
    public class AirportSelectorService : IAirportSelectorService {
        public Airport SelectAirport() {
            using (ArsContext db = new ArsContext()) {
                AirportSelectorForm form = new AirportSelectorForm();

                db.Airports.Load();

                form.DataSource = db.Airports.Local.AsEnumerable();
                form.SearchColumn = "Name";
                var result = form.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK) {
                    return form.SelectedValue;
                }
            }

            return null;
        }
    }
}
