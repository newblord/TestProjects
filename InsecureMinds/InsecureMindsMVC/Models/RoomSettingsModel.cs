using Business.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsecureMindsMVC.Models
{
    public class RoomSettingsModel
    {
        public IEnumerable<IPickType> PickTypes { get; set; }

        public IEnumerable<IExpansion> Expansions { get; set; }

        public IEnumerable<IHouseRule> HouseRules { get; set; }
    }
}