using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerIncome
    {
        public CustomerIncome()
        {
            LoanIncome = new HashSet<LoanIncome>();
        }

        public int CustomerIncomeKey { get; set; }
        public int CustomerKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public string AmountType { get; set; }
        public decimal IncomeAmount { get; set; }
        public int? IncomeVerifyMethodKey { get; set; }
        public DateTime? DateVerified { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedTeller { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int CustomerEmployerKey { get; set; }
        public string AmountCycle { get; set; }
        public bool IsActive { get; set; }
        public DateTime? DateInactive { get; set; }
        public string InactiveTeller { get; set; }

        public virtual ICollection<LoanIncome> LoanIncome { get; set; }
        public virtual CustomerEmployer CustomerEmployerKeyNavigation { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual IncomeVerifyMethod IncomeVerifyMethodKeyNavigation { get; set; }
    }
}
