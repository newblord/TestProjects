using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebLeadSale
    {
        public int WebleadsaleKey { get; set; }
        public DateTime DateEntered { get; set; }
        public int LoanApplicationKey { get; set; }
        public byte Status { get; set; }
        public int LeadId { get; set; }
        public int BuyerId { get; set; }
        public string DeliveryUrl { get; set; }
        public string DeliveryMsg { get; set; }
        public string Error { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public decimal Price { get; set; }
    }
}
