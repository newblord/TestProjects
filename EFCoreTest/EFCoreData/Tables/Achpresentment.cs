using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Achpresentment
    {
        public int AchPresentmentKey { get; set; }
        public int? AchParentPresentmentIdKey { get; set; }
        public int AchPresentmentTypeKey { get; set; }
        public int? LoanKey { get; set; }
        public int? RisreptKey { get; set; }
        public int? ReferenceKey { get; set; }
        public decimal Amt { get; set; }
        public bool IsDone { get; set; }
        public int ScheduledPaymentNumber { get; set; }
        public int CollectionPaymentNumber { get; set; }
        public int FeePaymentNumber { get; set; }
        public string StatementId { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }

        public virtual AchpresentmentType AchPresentmentTypeKeyNavigation { get; set; }
    }
}
