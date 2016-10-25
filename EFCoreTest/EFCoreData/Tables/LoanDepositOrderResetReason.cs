using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanDepositOrderResetReason
    {
        public LoanDepositOrderResetReason()
        {
            LoanDepositOrderHistory = new HashSet<LoanDepositOrderHistory>();
        }

        public int LoanDepositOrderResetReasonKey { get; set; }
        public short Reason { get; set; }
        public string Description { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }

        public virtual ICollection<LoanDepositOrderHistory> LoanDepositOrderHistory { get; set; }
    }
}
