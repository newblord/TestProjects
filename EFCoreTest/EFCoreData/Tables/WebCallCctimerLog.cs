using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallCctimerLog
    {
        public int CallCenterTimerLogKey { get; set; }
        public string CalledMethodName { get; set; }
        public string CalledFromName { get; set; }
        public string Teller { get; set; }
        public string TimeStampType { get; set; }
        public DateTime? TimeStamp { get; set; }
    }
}
