using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class GoldTransfer
    {
        public GoldTransfer()
        {
            GoldTransferDetail = new HashSet<GoldTransferDetail>();
        }

        public int GoldTransferKey { get; set; }
        public short Location { get; set; }
        public int TransDetailKey { get; set; }
        public DateTime SentDate { get; set; }
        public string SentBy { get; set; }
        public int? SentDailyBagCnt { get; set; }
        public decimal SentDailyBagAmt { get; set; }
        public DateTime? RecvDate { get; set; }
        public string RecvBy { get; set; }
        public int? RecvDailyBagCnt { get; set; }
        public decimal? RecvDailyBagAmt { get; set; }
        public string CourierTrackingNum { get; set; }
        public string CourierName { get; set; }

        public virtual ICollection<GoldTransferDetail> GoldTransferDetail { get; set; }
    }
}
