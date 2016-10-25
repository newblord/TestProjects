using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class EoscarDisputeCode
    {
        public EoscarDisputeCode()
        {
            EoscarDetailDisputeCode = new HashSet<EoscarDetailDisputeCode>();
        }

        public int EoscarDisputeCodeKey { get; set; }
        public string DisputeCode { get; set; }
        public string Description { get; set; }
        public bool ManualProcess { get; set; }

        public virtual ICollection<EoscarDetailDisputeCode> EoscarDetailDisputeCode { get; set; }
    }
}
