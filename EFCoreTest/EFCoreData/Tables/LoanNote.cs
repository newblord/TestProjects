using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanNote
    {
        public LoanNote()
        {
            LoanOverride = new HashSet<LoanOverride>();
        }

        public int LoanNoteKey { get; set; }
        public int LoanKey { get; set; }
        public int CustomerKey { get; set; }
        public string Note { get; set; }
        public string RtfNote { get; set; }
        public bool IsFlash { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string DeletedBy { get; set; }
        public int? NewLoanNoteKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }

        public virtual ICollection<LoanOverride> LoanOverride { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
    }
}
