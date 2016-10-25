using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class RbcEfundBatch
    {
        public RbcEfundBatch()
        {
            RbcEfundBatchDetail = new HashSet<RbcEfundBatchDetail>();
            RbcEfundBatchSummary = new HashSet<RbcEfundBatchSummary>();
        }

        public int RbcEfundBatchKey { get; set; }
        public DateTime DateEntered { get; set; }
        public short DetailCount { get; set; }
        public decimal DetailValue { get; set; }
        public DateTime? ResponseDate { get; set; }
        public string SendFileName { get; set; }
        public bool FileWritten { get; set; }
        public bool Accepted { get; set; }

        public virtual ICollection<RbcEfundBatchDetail> RbcEfundBatchDetail { get; set; }
        public virtual ICollection<RbcEfundBatchSummary> RbcEfundBatchSummary { get; set; }
    }
}
