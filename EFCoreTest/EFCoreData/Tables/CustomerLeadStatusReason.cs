using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerLeadStatusReason
    {
        public int CustomerLeadStatusReasonKey { get; set; }
        public int CustomerLeadStatusKey { get; set; }
        public int CustomerLeadReasonKey { get; set; }

        public virtual CustomerLeadReason CustomerLeadReasonKeyNavigation { get; set; }
        public virtual CustomerLeadStatus CustomerLeadStatusKeyNavigation { get; set; }
    }
}
