using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallCampaignCategory
    {
        public int WebCallCampaignCategoryKey { get; set; }
        public int WebCallCampaignKey { get; set; }
        public int WebCallCategoryKey { get; set; }
        public short SortPriority { get; set; }

        public virtual WebCallCampaign WebCallCampaignKeyNavigation { get; set; }
        public virtual WebCallCategory WebCallCategoryKeyNavigation { get; set; }
    }
}
