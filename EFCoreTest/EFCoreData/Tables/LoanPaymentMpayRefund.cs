using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanPaymentMpayRefund
    {
        public int LoanPaymentMpayRefundKey { get; set; }
        public int AccountingLoanPaymentKey { get; set; }
        public int LoanPaymentRefundXrefKey { get; set; }
        public decimal CollFeePastDueRefunded { get; set; }
        public decimal LegalFeePastDueRefunded { get; set; }
        public decimal LoanFeeDueRefunded { get; set; }
        public decimal TransFeeDueRefunded { get; set; }
        public decimal InterestDueRefunded { get; set; }
        public decimal PrincDueRefunded { get; set; }
        public decimal CabCollFeePastDueRefunded { get; set; }
        public decimal CabInterestDueRefunded { get; set; }
        public decimal NsfFeePastDueRefunded { get; set; }
        public decimal InsuranceDueRefunded { get; set; }

        public virtual LoanPaymentRefundXref LoanPaymentRefundXrefKeyNavigation { get; set; }
    }
}
