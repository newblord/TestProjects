using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DepositChkDetail
    {
        public int DepositChkDetailKey { get; set; }
        public int DepositChkKey { get; set; }
        public int CustomerKey { get; set; }
        public int TransDetailKey { get; set; }
        public int? LoanKey { get; set; }
        public int? CashedCheckKey { get; set; }

        public virtual CashedCheck CashedCheckKeyNavigation { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual DepositChk DepositChkKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
    }
}
