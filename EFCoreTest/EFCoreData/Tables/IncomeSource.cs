using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class IncomeSource
    {
        public IncomeSource()
        {
            CustomerEmployer = new HashSet<CustomerEmployer>();
            LoanApplicationEmployer = new HashSet<LoanApplicationEmployer>();
        }

        public int IncomeSourceKey { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int IncomeTypeKey { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }

        public virtual ICollection<CustomerEmployer> CustomerEmployer { get; set; }
        public virtual ICollection<LoanApplicationEmployer> LoanApplicationEmployer { get; set; }
        public virtual IncomeType IncomeTypeKeyNavigation { get; set; }
    }
}
