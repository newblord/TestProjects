using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DiscountUsed
    {
        public int DiscountUsedKey { get; set; }
        public int DiscountMasterKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public short Location { get; set; }
        public string ProductType { get; set; }
        public string LoanType { get; set; }
        public decimal DiscountAmt { get; set; }
        public string Zipcode { get; set; }
        public string RouteCode { get; set; }
        public int? LoanKey { get; set; }
        public int TransDetailKey { get; set; }
        public int? CashedCheckKey { get; set; }

        public virtual DiscountMaster DiscountMasterKeyNavigation { get; set; }
    }
}
