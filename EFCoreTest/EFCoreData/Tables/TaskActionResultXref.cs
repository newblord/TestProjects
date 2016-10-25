using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class TaskActionResultXref
    {
        public int TaskActionResultXrefKey { get; set; }
        public int TaskActionResultKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTeller { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }

        public virtual TaskActionResult TaskActionResultKeyNavigation { get; set; }
    }
}
