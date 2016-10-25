using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerLeadAction
    {
        public CustomerLeadAction()
        {
            CustomerLeadActivity = new HashSet<CustomerLeadActivity>();
        }

        public int CustomerLeadActionKey { get; set; }
        public string Action { get; set; }
        public bool IsActive { get; set; }
        public int CustomerLeadStatusKey { get; set; }

        public virtual ICollection<CustomerLeadActivity> CustomerLeadActivity { get; set; }
    }
}
