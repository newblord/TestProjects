using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallApplicationModeAudit
    {
        public int WebCallApplicationModeAuditKey { get; set; }
        public int WebCallApplicationModeKey { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string User { get; set; }

        public virtual WebCallApplicationModes WebCallApplicationModeKeyNavigation { get; set; }
    }
}
