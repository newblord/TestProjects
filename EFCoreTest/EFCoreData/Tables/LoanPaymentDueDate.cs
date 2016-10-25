using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanPaymentDueDate
    {
        public int LoanPaymentDueDateKey { get; set; }
        public int LoanPaymentKey { get; set; }
        public DateTime OrigDueDate { get; set; }
        public DateTime AdjustedDueDate { get; set; }
        public decimal PastDueAmt { get; set; }
        public decimal CollectionsAmt { get; set; }
        public decimal PendingAchAmt { get; set; }

        public virtual LoanPayment LoanPaymentKeyNavigation { get; set; }
    }
}
