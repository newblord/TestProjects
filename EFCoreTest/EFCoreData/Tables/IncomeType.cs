using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class IncomeType
    {
        public IncomeType()
        {
            CustomerEmployer = new HashSet<CustomerEmployer>();
            IncomeSource = new HashSet<IncomeSource>();
            IncomeTypeLocation = new HashSet<IncomeTypeLocation>();
            LoanApplicationEmployer = new HashSet<LoanApplicationEmployer>();
        }

        public int IncomeTypeKey { get; set; }
        public string IncomeTypeCode { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }

        public virtual ICollection<CustomerEmployer> CustomerEmployer { get; set; }
        public virtual ICollection<IncomeSource> IncomeSource { get; set; }
        public virtual ICollection<IncomeTypeLocation> IncomeTypeLocation { get; set; }
        public virtual ICollection<LoanApplicationEmployer> LoanApplicationEmployer { get; set; }
    }
}
