using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CardBatchSettle
    {
        public int CardBatchSettleKey { get; set; }
        public int? EodVaultCountKey { get; set; }
        public string RequestData { get; set; }
        public string ResponseData { get; set; }
        public bool Accepted { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime DateEntered { get; set; }
        public short Location { get; set; }
        public DateTime? EndBatchDateTime { get; set; }

        public virtual VaultCount EodVaultCountKeyNavigation { get; set; }
    }
}
