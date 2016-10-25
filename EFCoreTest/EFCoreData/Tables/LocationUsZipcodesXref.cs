using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LocationUsZipcodesXref
    {
        public short Location { get; set; }
        public string Zipcode { get; set; }
        public byte LenderKey { get; set; }
        public bool Enabled { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Company LocationNavigation { get; set; }
        public virtual UsZipcodes ZipcodeNavigation { get; set; }
    }
}
