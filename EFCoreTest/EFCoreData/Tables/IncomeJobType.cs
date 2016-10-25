using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class IncomeJobType
    {
        public IncomeJobType()
        {
            CustomerEmployer = new HashSet<CustomerEmployer>();
            FurtherFinanceJobType = new HashSet<FurtherFinanceJobType>();
            LoanApplicationEmployer = new HashSet<LoanApplicationEmployer>();
        }

        public int IncomeJobTypeKey { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public decimal WageLimit { get; set; }
        public short DaysToRerequest { get; set; }

        public virtual ICollection<CustomerEmployer> CustomerEmployer { get; set; }
        public virtual ICollection<FurtherFinanceJobType> FurtherFinanceJobType { get; set; }
        public virtual ICollection<LoanApplicationEmployer> LoanApplicationEmployer { get; set; }
    }
}
