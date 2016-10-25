using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AutoReportSchedule
    {
        public int AutoReportScheduleKey { get; set; }
        public int AutoReportKey { get; set; }
        public int AutoReportRunScheduleKey { get; set; }

        public virtual AutoReport AutoReportKeyNavigation { get; set; }
        public virtual AutoReportRunSchedule AutoReportRunScheduleKeyNavigation { get; set; }
    }
}
