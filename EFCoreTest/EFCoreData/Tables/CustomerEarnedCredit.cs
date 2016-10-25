using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerEarnedCredit
    {
        public CustomerEarnedCredit()
        {
            EarnedCreditTrans = new HashSet<EarnedCreditTrans>();
        }

        public int CustomerEarnedCreditKey { get; set; }
        public int CustomerKey { get; set; }
        public int EarnedCreditTypeKey { get; set; }
        public DateTime? ExpireDate { get; set; }
        public decimal TotalEarned { get; set; }
        public decimal TotalRedeemed { get; set; }

        public virtual ICollection<EarnedCreditTrans> EarnedCreditTrans { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual EarnedCreditType EarnedCreditTypeKeyNavigation { get; set; }
    }
}
