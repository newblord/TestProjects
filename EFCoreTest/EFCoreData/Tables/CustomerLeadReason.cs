using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerLeadReason
    {
        public CustomerLeadReason()
        {
            CustomerLead = new HashSet<CustomerLead>();
            CustomerLeadStatusReason = new HashSet<CustomerLeadStatusReason>();
        }

        public int CustomerLeadReasonKey { get; set; }
        public string Reason { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<CustomerLead> CustomerLead { get; set; }
        public virtual ICollection<CustomerLeadStatusReason> CustomerLeadStatusReason { get; set; }
    }
}
