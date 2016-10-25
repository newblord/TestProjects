using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanStatusChange
    {
        public int LoanStatusChangeKey { get; set; }
        public int LoanKey { get; set; }
        public int TransDetailKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string OldLoanStatus { get; set; }
        public string NewLoanStatus { get; set; }
        public bool OldLoanDefaulted { get; set; }
        public bool NewLoanDefaulted { get; set; }
        public string ReasonDefaulted { get; set; }
        public bool Reversed { get; set; }
        public DateTime? ReversedDate { get; set; }
    }
}
