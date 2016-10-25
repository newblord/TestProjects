using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CompanyDetail
    {
        public short Location { get; set; }
        public string Address { get; set; }
        public string CrossStreets { get; set; }
        public string Directions { get; set; }
        public string NewsFlash { get; set; }
        public string Fax { get; set; }
        public string AlternateHours { get; set; }
        public string StoreEmailAddress { get; set; }

        public virtual Company LocationNavigation { get; set; }
    }
}
