using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class MpayAmortDueDateChange
    {
        public int MpayAmortDueDateChangeKey { get; set; }
        public int LoanKey { get; set; }
        public int MpayAmortKey { get; set; }
        public DateTime AdjustedDueDate { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string DeletedBy { get; set; }

        public virtual Loan LoanKeyNavigation { get; set; }
        public virtual MpayAmort MpayAmortKeyNavigation { get; set; }
    }
}
