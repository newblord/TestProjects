using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ProcessSchedule
    {
        public int ProcessScheduleKey { get; set; }
        public int ProcessConfigInstanceKey { get; set; }
        public string JobName { get; set; }
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
        public DateTime? StartTime { get; set; }
        public string TimeZone { get; set; }
        public bool IsRestart { get; set; }

        public virtual ProcessConfigInstance ProcessConfigInstanceKeyNavigation { get; set; }
    }
}
