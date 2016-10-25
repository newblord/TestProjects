using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class RiccAutoRoll
    {
        public int RiccAutoRollKey { get; set; }
        public int? RisreptKey { get; set; }
        public DateTime? DateEntered { get; set; }
        public int ZeroLoanKey { get; set; }
        public int OrigLoanKey { get; set; }
        public int NewLoanKey { get; set; }
        public decimal FeeAmt { get; set; }
        public decimal SurchargeAmt { get; set; }
        public decimal CollectedAmt { get; set; }
        public DateTime? EmailSent { get; set; }
        public DateTime? LetterSent { get; set; }

        public virtual Loan NewLoanKeyNavigation { get; set; }
        public virtual Loan OrigLoanKeyNavigation { get; set; }
        public virtual Risrept RisreptKeyNavigation { get; set; }
    }
}
