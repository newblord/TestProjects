using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanPaymentSpayRefund
    {
        public int LoanPaymentSpayRefundKey { get; set; }
        public int AccountingLoanPaymentKey { get; set; }
        public int LoanPaymentRefundXrefKey { get; set; }
        public decimal CollFeeDueRefunded { get; set; }
        public decimal LegalFeeDueRefunded { get; set; }
        public decimal LoanFeeDueRefunded { get; set; }
        public decimal InterestDueRefunded { get; set; }
        public decimal CabInterestDueRefunded { get; set; }
        public decimal PrincDueRefunded { get; set; }
        public decimal CabLenderCollFeeDueRefunded { get; set; }
        public decimal NsfFeeDueRefunded { get; set; }

        public virtual LoanPaymentRefundXref LoanPaymentRefundXrefKeyNavigation { get; set; }
    }
}
