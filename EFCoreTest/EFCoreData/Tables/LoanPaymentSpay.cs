using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanPaymentSpay
    {
        public int LoanPaymentSpayKey { get; set; }
        public int LoanPaymentKey { get; set; }
        public decimal CollFeeDuePaidAmt { get; set; }
        public decimal LegalFeeDuePaidAmt { get; set; }
        public decimal LoanFeeDuePaidAmt { get; set; }
        public decimal InterestDuePaidAmt { get; set; }
        public decimal CabInterestDuePaidAmt { get; set; }
        public decimal PrincDuePaidAmt { get; set; }
        public decimal CabLenderCollFeePastDuePaidAmt { get; set; }
        public decimal NsfFeeDuePaidAmt { get; set; }
        public decimal TransFeeDuePaidAmt { get; set; }
        public decimal PendingSchedAchAmt { get; set; }

        public virtual LoanPayment LoanPaymentKeyNavigation { get; set; }
    }
}
