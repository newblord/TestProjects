using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Lender
    {
        public Lender()
        {
            LoanApplication = new HashSet<LoanApplication>();
            Visitor = new HashSet<Visitor>();
        }

        public byte LenderKey { get; set; }
        public string LenderId { get; set; }
        public string LenderName { get; set; }
        public bool QualifyCuroCustomer { get; set; }
        public bool Enabled { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<LoanApplication> LoanApplication { get; set; }
        public virtual ICollection<Visitor> Visitor { get; set; }
    }
}
