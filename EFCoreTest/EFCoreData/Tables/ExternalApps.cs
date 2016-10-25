using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ExternalApps
    {
        public ExternalApps()
        {
            ExternalAppConfig = new HashSet<ExternalAppConfig>();
            ExternalAppRunDates = new HashSet<ExternalAppRunDates>();
        }

        public int ExternalAppsKey { get; set; }
        public string AppName { get; set; }
        public string AppInstance { get; set; }
        public string AppDescription { get; set; }
        public string CmdNamedArg { get; set; }

        public virtual ICollection<ExternalAppConfig> ExternalAppConfig { get; set; }
        public virtual ICollection<ExternalAppRunDates> ExternalAppRunDates { get; set; }
    }
}
