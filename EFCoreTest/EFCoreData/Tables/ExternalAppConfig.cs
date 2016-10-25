using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ExternalAppConfig
    {
        public int ExternalAppConfigKey { get; set; }
        public int ExternalAppsKey { get; set; }
        public string ConfigName { get; set; }
        public string ConfigValue { get; set; }

        public virtual ExternalApps ExternalAppsKeyNavigation { get; set; }
    }
}
