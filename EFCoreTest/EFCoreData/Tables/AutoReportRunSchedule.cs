using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AutoReportRunSchedule
    {
        public AutoReportRunSchedule()
        {
            AutoReportSchedule = new HashSet<AutoReportSchedule>();
        }

        public int AutoReportRunScheduleKey { get; set; }
        public int RunTime { get; set; }
        public bool Sun { get; set; }
        public bool Mon { get; set; }
        public bool Tues { get; set; }
        public bool Wed { get; set; }
        public bool Thurs { get; set; }
        public bool Fri { get; set; }
        public bool Sat { get; set; }
        public short MonthlyDay { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string JobName { get; set; }
        public DateTime? StartTime { get; set; }
        public bool? Hourly { get; set; }
        public int? EveryXMinutes { get; set; }
        public DateTime? EndTime { get; set; }
        public string TimeZone { get; set; }

        public virtual ICollection<AutoReportSchedule> AutoReportSchedule { get; set; }
    }
}
