using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanDepositOrderHistory
    {
        public int LoanDepositOrderHistoryKey { get; set; }
        public int? RuleDefKey { get; set; }
        public int LoanKey { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public byte OldDepositOrder { get; set; }
        public byte NewDepositOrder { get; set; }
        public string Description { get; set; }
        public int? ResetReasonKey { get; set; }

        public virtual LoanDepositOrderResetReason ResetReasonKeyNavigation { get; set; }
        public virtual RuleDef RuleDefKeyNavigation { get; set; }
    }
}
