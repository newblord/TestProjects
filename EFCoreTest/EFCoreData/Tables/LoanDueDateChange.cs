using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanDueDateChange
    {
        public int DuedateChangeKey { get; set; }
        public int LoanKey { get; set; }
        public int CustomerKey { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime AdjustedDueDate { get; set; }
        public int? TransDetailKey { get; set; }
        public bool IsDuedateChanged { get; set; }
        public int? LoanCheckKey { get; set; }
        public string ChangeNote { get; set; }
        public int? OpenEndLoanStmtKey { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
        public virtual OpenEndLoanStatement OpenEndLoanStmtKeyNavigation { get; set; }
    }
}
