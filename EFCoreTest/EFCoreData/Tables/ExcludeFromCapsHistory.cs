using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ExcludeFromCapsHistory
    {
        public int ExcludeFromCapsHistoryKey { get; set; }
        public int LoanKey { get; set; }
        public string Teller { get; set; }
        public short Location { get; set; }
        public DateTime DateEntered { get; set; }
        public bool ExcludeFromCaps { get; set; }
        public bool ExcludeFromCapsAch { get; set; }
        public string OptOutReason { get; set; }

        public virtual Loan LoanKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
        public virtual Tellerid TellerNavigation { get; set; }
    }
}
