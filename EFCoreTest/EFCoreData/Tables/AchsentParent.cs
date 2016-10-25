using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AchsentParent
    {
        public AchsentParent()
        {
            AchSent = new HashSet<AchSent>();
        }

        public int AchSentParentKey { get; set; }
        public string AchFileNameSent { get; set; }
        public string AchFileNameAck { get; set; }
        public int AchFileRecCnt { get; set; }
        public decimal AchFileTotalAmt { get; set; }
        public DateTime AchSentDate { get; set; }
        public string FileType { get; set; }
        public bool ScheduledPayments { get; set; }
        public bool? IsAdAstra { get; set; }
        public bool? IsDayAfterDueSent { get; set; }
        public DateTime? ExpectedResults { get; set; }

        public virtual ICollection<AchSent> AchSent { get; set; }
    }
}
