using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebLeadBuyers
    {
        public int LeadBuyerKey { get; set; }
        public int? ExternalBuyerId { get; set; }
        public string BuyerName { get; set; }
        public int? TierAmt { get; set; }
        public string ParentBuyer { get; set; }
    }
}
