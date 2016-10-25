using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AchRecv
    {
        public AchRecv()
        {
            AchHistory = new HashSet<AchHistory>();
            AchHistoryCashedCheck = new HashSet<AchHistoryCashedCheck>();
            AchSent = new HashSet<AchSent>();
            Uddreport = new HashSet<Uddreport>();
        }

        public int AchRecvKey { get; set; }
        public string FileNameRecv { get; set; }
        public DateTime DateRecv { get; set; }
        public int PaidCount { get; set; }
        public decimal PaidTotal { get; set; }
        public int UnpaidCount { get; set; }
        public decimal UnpaidTotal { get; set; }
        public DateTime? Btime { get; set; }

        public virtual ICollection<AchHistory> AchHistory { get; set; }
        public virtual ICollection<AchHistoryCashedCheck> AchHistoryCashedCheck { get; set; }
        public virtual ICollection<AchSent> AchSent { get; set; }
        public virtual ICollection<Uddreport> Uddreport { get; set; }
    }
}
