using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallCampaign
    {
        public WebCallCampaign()
        {
            WebCallCampaignCategory = new HashSet<WebCallCampaignCategory>();
        }

        public int WebCallCampaignKey { get; set; }
        public string Name { get; set; }

        public virtual ICollection<WebCallCampaignCategory> WebCallCampaignCategory { get; set; }
    }
}
