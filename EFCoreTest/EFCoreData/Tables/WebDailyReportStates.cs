using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebDailyReportStates
    {
        public int WebDailyReportStateKey { get; set; }
        public string State { get; set; }
        public int StateSortPriority { get; set; }
        public bool Disabled { get; set; }
    }
}
