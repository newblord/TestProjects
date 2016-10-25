using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanProductConfigInsuranceRate
    {
        public int LoanProductConfigInsuranceRateKey { get; set; }
        public int LoanProductConfigKey { get; set; }
        public decimal FeePerPaymentPct { get; set; }
        public decimal LoanUpToAmt { get; set; }
        public string PaymentCycle { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual LoanProductConfig LoanProductConfigKeyNavigation { get; set; }
    }
}
