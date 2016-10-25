using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanPaymentMpay
    {
        public int LoanPaymentMpayKey { get; set; }
        public int LoanPaymentKey { get; set; }
        public bool AddToColl { get; set; }
        public bool RemFromColl { get; set; }
        public decimal PendingSchedAchAmt { get; set; }
        public bool IsCoEarlyPayoffRebate { get; set; }
        public decimal CollFeePastDuePaid { get; set; }
        public decimal LegalFeePastDuePaid { get; set; }
        public decimal LoanFeeDuePaid { get; set; }
        public decimal TransFeeDuePaid { get; set; }
        public decimal InterestDuePaid { get; set; }
        public decimal PrincDuePaid { get; set; }
        public decimal PaymentDuePaid { get; set; }
        public decimal PaymentPastDuePaid { get; set; }
        public decimal CabCollFeePastDuePaid { get; set; }
        public decimal CabInterestDuePaid { get; set; }
        public bool IsScheduledPayment { get; set; }
        public bool IsDayAfterDuePayment { get; set; }
        public decimal NsfFeePastDuePaid { get; set; }
        public decimal InsuranceDuePaid { get; set; }
        public decimal DueDatePaymentQueuePaid { get; set; }

        public virtual LoanPayment LoanPaymentKeyNavigation { get; set; }
    }
}
