using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ExternalAppRunDates
    {
        public int ExternalAppsRunDatesKey { get; set; }
        public int ExternalAppsKey { get; set; }
        public DateTime? RunDate { get; set; }
        public byte Priority { get; set; }

        public virtual ExternalApps ExternalAppsKeyNavigation { get; set; }
    }
}
