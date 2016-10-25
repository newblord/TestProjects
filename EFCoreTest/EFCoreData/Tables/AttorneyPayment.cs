using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AttorneyPayment
    {
        public int AttorneyPaymentKey { get; set; }
        public int AttorneyLoanKey { get; set; }
        public int? CashedCheckPaymentKey { get; set; }
        public int? LoanPaymentKey { get; set; }
        public short AttorneyKey { get; set; }
        public DateTime? SentToAttorney { get; set; }
        public decimal AmtDueAttorney { get; set; }
        public bool Reversed { get; set; }
        public DateTime? ReversedDate { get; set; }

        public virtual Attorney AttorneyKeyNavigation { get; set; }
        public virtual AttorneyLoan AttorneyLoanKeyNavigation { get; set; }
        public virtual CashedCheckPayment CashedCheckPaymentKeyNavigation { get; set; }
        public virtual LoanPayment LoanPaymentKeyNavigation { get; set; }
    }
}
