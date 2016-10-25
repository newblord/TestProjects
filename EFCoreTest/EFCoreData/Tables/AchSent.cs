using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AchSent
    {
        public AchSent()
        {
            AchHistory = new HashSet<AchHistory>();
            AchHistoryCashedCheck = new HashSet<AchHistoryCashedCheck>();
        }

        public int AchSentKey { get; set; }
        public short? Location { get; set; }
        public string FileNameSent { get; set; }
        public string FileNameUpdated { get; set; }
        public int ItemCount { get; set; }
        public decimal ItemTotal { get; set; }
        public DateTime DateSent { get; set; }
        public DateTime ExpectedResults { get; set; }
        public int? AchRecvKey { get; set; }
        public bool ScheduledPayments { get; set; }
        public bool? IsAdAstra { get; set; }
        public string FileType { get; set; }
        public bool? IsDayAfterDueSent { get; set; }
        public int? AchSentParentKey { get; set; }

        public virtual ICollection<AchHistory> AchHistory { get; set; }
        public virtual ICollection<AchHistoryCashedCheck> AchHistoryCashedCheck { get; set; }
        public virtual AchRecv AchRecvKeyNavigation { get; set; }
        public virtual AchsentParent AchSentParentKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
    }
}
