using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanDocPrinted
    {
        public int LoanDocPrintedKey { get; set; }
        public int? LoanKey { get; set; }
        public int LoanDocKey { get; set; }
        public int CustomerKey { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public int TransDetailKey { get; set; }

        public virtual LoanDoc LoanDocKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
    }
}
