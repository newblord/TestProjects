using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerLeadActivity
    {
        public int CustomerLeadActivityKey { get; set; }
        public int CustomerLeadKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public int CustomerLeadActionKey { get; set; }
        public int CustomerLeadStatusKey { get; set; }
        public int? CustomerLeadReasonKey { get; set; }

        public virtual CustomerLeadAction CustomerLeadActionKeyNavigation { get; set; }
        public virtual CustomerLead CustomerLeadKeyNavigation { get; set; }
        public virtual CustomerLeadStatus CustomerLeadStatusKeyNavigation { get; set; }
    }
}
