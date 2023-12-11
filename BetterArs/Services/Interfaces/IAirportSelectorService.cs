using BetterArs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterArs.Services.Interfaces {
    public interface IAirportSelectorService {
        Airport SelectAirport();
    }
}
