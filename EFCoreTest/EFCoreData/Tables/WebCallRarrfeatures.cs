using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallRarrfeatures
    {
        public int WebCallRarrFeaturesKey { get; set; }
        public int WebCallRarrKey { get; set; }
        public int WebCallFeaturesKey { get; set; }
        public bool FeatureEnable { get; set; }
        public bool SupDualAuthEnabled { get; set; }
        public bool CsrdualAuthEnabled { get; set; }

        public virtual WebCallFeatures WebCallFeaturesKeyNavigation { get; set; }
        public virtual WebCallRarr WebCallRarrKeyNavigation { get; set; }
    }
}
