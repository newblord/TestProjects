using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AttorneyLoan
    {
        public AttorneyLoan()
        {
            AttorneyPayment = new HashSet<AttorneyPayment>();
        }

        public int AttorneyLoanKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public int? LoanKey { get; set; }
        public int? CashedCheckKey { get; set; }
        public short AttorneyKey { get; set; }
        public short CommissionPct { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<AttorneyPayment> AttorneyPayment { get; set; }
        public virtual Attorney AttorneyKeyNavigation { get; set; }
        public virtual CashedCheck CashedCheckKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
    }
}
