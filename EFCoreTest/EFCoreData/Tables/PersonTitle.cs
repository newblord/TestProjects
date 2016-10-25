using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PersonTitle
    {
        public PersonTitle()
        {
            Customer = new HashSet<Customer>();
            LoanApplication = new HashSet<LoanApplication>();
        }

        public int PersonTitleKey { get; set; }
        public string Description { get; set; }
        public string Abbreviation { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<LoanApplication> LoanApplication { get; set; }
    }
}
