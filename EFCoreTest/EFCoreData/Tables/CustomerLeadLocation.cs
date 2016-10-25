using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerLeadLocation
    {
        public int CustomerLeadLocationKey { get; set; }
        public short Location { get; set; }
        public bool IsSuperstore { get; set; }
        public short OfSuperstore { get; set; }
        public short? SuperstoreRadius { get; set; }
        public short? WarningAge { get; set; }
        public short? RefreshRate { get; set; }

        public virtual Company LocationNavigation { get; set; }
    }
}
