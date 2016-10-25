using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class EarnedCreditTrans
    {
        public int EarnedCreditTransKey { get; set; }
        public int CustomerEarnedCreditKey { get; set; }
        public int TransDetailKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public decimal EarnedAmt { get; set; }
        public bool Reversed { get; set; }
        public DateTime? ReversedDate { get; set; }

        public virtual CustomerEarnedCredit CustomerEarnedCreditKeyNavigation { get; set; }
        public virtual TransDetail TransDetailKeyNavigation { get; set; }
    }
}
