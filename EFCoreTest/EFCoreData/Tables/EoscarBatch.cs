using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class EoscarBatch
    {
        public EoscarBatch()
        {
            EoscarBatchDetailEoscarBatchKeyRecvNavigation = new HashSet<EoscarBatchDetail>();
            EoscarBatchDetailEoscarBatchKeySentNavigation = new HashSet<EoscarBatchDetail>();
        }

        public int EoscarBatchKey { get; set; }
        public DateTime DateEntered { get; set; }
        public int BatchId { get; set; }
        public int QueueId { get; set; }
        public string Teller { get; set; }
        public string SendRecv { get; set; }
        public string RawXml { get; set; }

        public virtual ICollection<EoscarBatchDetail> EoscarBatchDetailEoscarBatchKeyRecvNavigation { get; set; }
        public virtual ICollection<EoscarBatchDetail> EoscarBatchDetailEoscarBatchKeySentNavigation { get; set; }
        public virtual Tellerid TellerNavigation { get; set; }
    }
}
