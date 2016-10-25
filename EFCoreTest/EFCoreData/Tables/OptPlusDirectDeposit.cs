using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OptPlusDirectDeposit
    {
        public int OptplusDirectDepositKey { get; set; }
        public int CustomerKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public decimal DepositAmt { get; set; }
        public bool IsEligibleDeposit { get; set; }
        public int OptplusMerchantKey { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual OptPlusMerchant OptplusMerchantKeyNavigation { get; set; }
    }
}
