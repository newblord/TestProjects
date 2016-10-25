using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerLeadNote
    {
        public int CustomerLeadNoteKey { get; set; }
        public int CustomerLeadKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public string Note { get; set; }

        public virtual CustomerLead CustomerLeadKeyNavigation { get; set; }
    }
}
