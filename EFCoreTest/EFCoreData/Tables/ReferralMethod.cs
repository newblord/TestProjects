using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ReferralMethod
    {
        public ReferralMethod()
        {
            Customer = new HashSet<Customer>();
            LoanApplication = new HashSet<LoanApplication>();
        }

        public short ReferralMethodKey { get; set; }
        public string ReferralCode { get; set; }
        public string ReferralDesc { get; set; }
        public short CuroOrder { get; set; }
        public short WebOrder { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<LoanApplication> LoanApplication { get; set; }
    }
}
