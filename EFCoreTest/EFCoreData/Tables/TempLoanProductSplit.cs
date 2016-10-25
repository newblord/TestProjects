using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class TempLoanProductSplit
    {
        public int TempLoanProductSplitKey { get; set; }
        public int OrigLoanProductKey { get; set; }
        public string OrigLoanProductName { get; set; }
        public int? NewLoanProductKey { get; set; }
        public string NewLoanProductName { get; set; }
        public int OrigLoanProductConfigKey { get; set; }
        public int? NewLoanProductConfigKey { get; set; }
        public short Location { get; set; }
        public string ProductType { get; set; }
        public string LoanType { get; set; }

        public virtual LoanProductConfig NewLoanProductConfigKeyNavigation { get; set; }
        public virtual LoanProduct NewLoanProductKeyNavigation { get; set; }
        public virtual LoanProductConfig OrigLoanProductConfigKeyNavigation { get; set; }
        public virtual LoanProduct OrigLoanProductKeyNavigation { get; set; }
    }
}
