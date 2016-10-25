using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DepositDebitCardDetail
    {
        public int DepositDebitCardDetailKey { get; set; }
        public int DepositDebitCardKey { get; set; }
        public int LoanKey { get; set; }
        public int? TransDetailKey { get; set; }
        public bool Reversed { get; set; }
        public string ReversedBy { get; set; }
        public DateTime? ReversedDate { get; set; }

        public virtual DepositDebitCard DepositDebitCardKeyNavigation { get; set; }
    }
}
