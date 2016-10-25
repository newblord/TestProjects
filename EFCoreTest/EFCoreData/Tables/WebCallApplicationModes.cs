using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallApplicationModes
    {
        public WebCallApplicationModes()
        {
            WebCallApplicationModeAudit = new HashSet<WebCallApplicationModeAudit>();
        }

        public int WebCallApplicationModeKey { get; set; }
        public string Name { get; set; }
        public int ActivationEvent { get; set; }
        public int OnSelectedAction { get; set; }
        public bool Disabled { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime DateEntered { get; set; }
        public bool Deleted { get; set; }
        public bool IsWorkingHoursMode { get; set; }

        public virtual ICollection<WebCallApplicationModeAudit> WebCallApplicationModeAudit { get; set; }
    }
}
