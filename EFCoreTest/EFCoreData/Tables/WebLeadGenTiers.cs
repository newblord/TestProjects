using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebLeadGenTiers
    {
        public int WebLeadGenKey { get; set; }
        public int Score { get; set; }
        public decimal? Price { get; set; }
        public int WebLeadGenTiersKey { get; set; }

        public virtual WebLeadGen WebLeadGenKeyNavigation { get; set; }
    }
}
