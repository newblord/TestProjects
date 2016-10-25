using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class EoscarBatchDetail
    {
        public EoscarBatchDetail()
        {
            EoscarDetailDisputeCode = new HashSet<EoscarDetailDisputeCode>();
        }

        public int EoscarBatchDetailKey { get; set; }
        public int EoscarBatchKeyRecv { get; set; }
        public int? EoscarBatchKeySent { get; set; }
        public int AcdvIdentifier { get; set; }
        public string AcdvControlNumber { get; set; }
        public int RisreptKey { get; set; }
        public int CustomerKey { get; set; }
        public bool ManualExport { get; set; }
        public bool ManualReview { get; set; }
        public bool Processed { get; set; }
        public string XmlRecv { get; set; }
        public string XmlSent { get; set; }

        public virtual ICollection<EoscarDetailDisputeCode> EoscarDetailDisputeCode { get; set; }
        public virtual EoscarBatch EoscarBatchKeyRecvNavigation { get; set; }
        public virtual EoscarBatch EoscarBatchKeySentNavigation { get; set; }
    }
}
