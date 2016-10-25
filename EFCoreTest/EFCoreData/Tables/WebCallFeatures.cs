using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallFeatures
    {
        public WebCallFeatures()
        {
            WebCallRarrfeatures = new HashSet<WebCallRarrfeatures>();
        }

        public int WebCallFeaturesKey { get; set; }
        public string Name { get; set; }
        public byte DisplayOrder { get; set; }
        public bool SupDualAuthEnabled { get; set; }
        public bool CsrdualAuthEnabled { get; set; }

        public virtual ICollection<WebCallRarrfeatures> WebCallRarrfeatures { get; set; }
    }
}
