using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CheckAgain
    {
        public CheckAgain()
        {
            CheckAgainHistory = new HashSet<CheckAgainHistory>();
        }

        public int CheckagainKey { get; set; }
        public int LoanKey { get; set; }
        public string Status { get; set; }
        public DateTime DateEntered { get; set; }
        public bool Sent { get; set; }

        public virtual ICollection<CheckAgainHistory> CheckAgainHistory { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
    }
}
