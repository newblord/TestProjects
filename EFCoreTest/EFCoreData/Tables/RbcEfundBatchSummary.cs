using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class RbcEfundBatchSummary
    {
        public int RbcEfundBatchSummaryKey { get; set; }
        public int RbcEfundBatchKey { get; set; }
        public DateTime DateEntered { get; set; }
        public decimal SuccessAmount { get; set; }
        public short SuccessCount { get; set; }
        public decimal UnsuccessAmount { get; set; }
        public short UnsuccessCount { get; set; }
        public bool Processed { get; set; }

        public virtual RbcEfundBatch RbcEfundBatchKeyNavigation { get; set; }
    }
}
