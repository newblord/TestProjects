using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallQueueConfiguration
    {
        public int WebCallQueueConfigurationKey { get; set; }
        public int DefaultOnlineRefreshRate { get; set; }
        public int DefaultTestUserRefreshRate { get; set; }
        public int DefaultCustomerSupportRefreshRate { get; set; }
        public int DefaultSummaryRefreshRate { get; set; }
        public int FollowUpDateHourThreshold { get; set; }
        public int FollowUpDateMinuteThreshold { get; set; }
    }
}
