using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class RiUrgentNote
    {
        public int RiUrgentNoteKey { get; set; }
        public string UrgentNoteText { get; set; }
        public DateTime DateEntered { get; set; }
        public int TellerIdKey { get; set; }
        public bool IsActive { get; set; }

        public virtual Tellerid TellerIdKeyNavigation { get; set; }
    }
}
