using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanProductConfigMaxLoanAmtRate
    {
        public int LoanProductConfigMaxLoanAmtRateKey { get; set; }
        public int LoanProductConfigKey { get; set; }
        public decimal IncomeRequiredAmt { get; set; }
        public decimal LoanAmtMaxAmt { get; set; }
        public byte LoanLengthMaxMonths { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual LoanProductConfig LoanProductConfigKeyNavigation { get; set; }
    }
}
