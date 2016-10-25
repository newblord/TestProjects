using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanFunding
    {
        public int LoanFundingKey { get; set; }
        public int LoanKey { get; set; }
        public int ApprovedLoanPaymentKey { get; set; }
        public int? FundingTransDetailKey { get; set; }
        public string RequestedFundingMethod { get; set; }
        public string ActualFundingMethod { get; set; }
        public decimal FundingAmt { get; set; }
        public string FundingStatus { get; set; }

        public virtual LoanPayment ApprovedLoanPaymentKeyNavigation { get; set; }
        public virtual TransDetail FundingTransDetailKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
    }
}
