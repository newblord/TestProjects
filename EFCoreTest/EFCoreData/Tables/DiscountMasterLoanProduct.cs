using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DiscountMasterLoanProduct
    {
        public int DiscountMasterLoanProductKey { get; set; }
        public int DiscountMasterKey { get; set; }
        public int LoanProductKey { get; set; }
        public string EnteredBy { get; set; }
        public DateTime DateEntered { get; set; }

        public virtual DiscountMaster DiscountMasterKeyNavigation { get; set; }
        public virtual LoanProduct LoanProductKeyNavigation { get; set; }
    }
}
