using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class EoscarDetailDisputeCode
    {
        public int EoscarDetailDisputeCodeKey { get; set; }
        public int EoscarBatchDetailKey { get; set; }
        public int EoscarDisputeCodeKey { get; set; }

        public virtual EoscarBatchDetail EoscarBatchDetailKeyNavigation { get; set; }
        public virtual EoscarDisputeCode EoscarDisputeCodeKeyNavigation { get; set; }
    }
}
