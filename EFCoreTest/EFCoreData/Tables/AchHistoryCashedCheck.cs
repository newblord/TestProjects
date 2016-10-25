using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AchHistoryCashedCheck
    {
        public int AchHistoryKey { get; set; }
        public int CustomerKey { get; set; }
        public short Location { get; set; }
        public int CashedCheckKey { get; set; }
        public decimal AchAmount { get; set; }
        public byte AchAttempt { get; set; }
        public bool AchAttempt2Hist { get; set; }
        public DateTime ProjSendDate { get; set; }
        public DateTime? ManualSendDate { get; set; }
        public string ManualTeller { get; set; }
        public int AchSentKey { get; set; }
        public int? AchRecvKey { get; set; }
        public string AchResultCode { get; set; }
        public DateTime DateEntered { get; set; }
        public string AbaNo { get; set; }
        public string BankNo { get; set; }
        public int Jobid { get; set; }
        public int? TransDetailKey { get; set; }

        public virtual AchRecv AchRecvKeyNavigation { get; set; }
        public virtual AchSent AchSentKeyNavigation { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
    }
}
