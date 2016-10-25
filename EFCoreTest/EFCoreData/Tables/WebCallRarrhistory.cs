using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallRarrhistory
    {
        public int WebCallRarrHistoryKey { get; set; }
        public int WebCallRarrKey { get; set; }
        public int WebCallQueueKey { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string Notes { get; set; }
        public bool IsFollowup { get; set; }
        public DateTime? FollowupDate { get; set; }
        public string Source { get; set; }
        public decimal? ForceApprovedAmount { get; set; }
        public int? RarrGroupKey { get; set; }
        public string RarrGroupName { get; set; }
        public int? RarrGroupPoints { get; set; }
        public int? TeamKey { get; set; }
        public string TeamName { get; set; }
        public int? WebDialerResultKey { get; set; }
        public bool? SuppressRarrPoints { get; set; }
        public string SuppressPointsReason { get; set; }

        public virtual WebCallQueue WebCallQueueKeyNavigation { get; set; }
    }
}
