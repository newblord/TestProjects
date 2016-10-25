using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanOverride
    {
        public int LoanOverrideKey { get; set; }
        public int LoanNoteKey { get; set; }
        public int LoanKey { get; set; }
        public string LoanOverrideType { get; set; }
        public byte LoanOverrideReason { get; set; }
        public decimal OrigValue { get; set; }
        public decimal OverrideValue { get; set; }

        public virtual Loan LoanKeyNavigation { get; set; }
        public virtual LoanNote LoanNoteKeyNavigation { get; set; }
    }
}
