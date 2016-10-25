using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanProductConfigLoanFeeRate
    {
        public int LoanProductConfigLoanFeeRateKey { get; set; }
        public int LoanProductConfigKey { get; set; }
        public decimal LoanUpToAmt { get; set; }
        public decimal LoanFeePct { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual LoanProductConfig LoanProductConfigKeyNavigation { get; set; }
    }
}
