using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DepositBagDetail
    {
        public int DepositBagDetailKey { get; set; }
        public int DepositBagKey { get; set; }
        public int CustomerKey { get; set; }
        public int TransDetailKey { get; set; }
        public int? LoanKey { get; set; }
        public int? CashedCheckKey { get; set; }
        public bool? ReversedDelete { get; set; }
        public string ReversedByDelete { get; set; }
        public DateTime? ReversedDateDelete { get; set; }
        public int? DrawerKey { get; set; }
        public int? LoanCheckKey { get; set; }

        public virtual CashedCheck CashedCheckKeyNavigation { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual DepositBag DepositBagKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
    }
}
