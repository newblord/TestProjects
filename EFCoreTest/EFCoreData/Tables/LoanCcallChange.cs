using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanCcallChange
    {
        public int LoanCcallChangeKey { get; set; }
        public int LoanKey { get; set; }
        public short Location { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public bool? CourtesyCall { get; set; }
        public bool? EmailStatements { get; set; }

        public virtual Loan LoanKeyNavigation { get; set; }
    }
}
