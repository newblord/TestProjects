using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class UsStates
    {
        public UsStates()
        {
            Company = new HashSet<Company>();
            Customer = new HashSet<Customer>();
            Issuer = new HashSet<Issuer>();
        }

        public string State { get; set; }
        public string StateName { get; set; }
        public bool IsUsState { get; set; }
        public bool IsCanadaProvince { get; set; }

        public virtual ICollection<Company> Company { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<Issuer> Issuer { get; set; }
    }
}
