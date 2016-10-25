using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerLeadStatus
    {
        public CustomerLeadStatus()
        {
            CustomerLeadActivity = new HashSet<CustomerLeadActivity>();
            CustomerLeadStatusReason = new HashSet<CustomerLeadStatusReason>();
        }

        public int CustomerLeadStatusKey { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool InF2Search { get; set; }
        public bool InQueueMaint { get; set; }
        public bool RequiresReason { get; set; }
        public short DisplayOrder { get; set; }
        public short DeleteAfterDays { get; set; }
        public bool RequiresDate { get; set; }
        public bool RequiresSatellite { get; set; }

        public virtual ICollection<CustomerLeadActivity> CustomerLeadActivity { get; set; }
        public virtual ICollection<CustomerLeadStatusReason> CustomerLeadStatusReason { get; set; }
    }
}
