using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class RbcEfundResponseCode
    {
        public RbcEfundResponseCode()
        {
            RbcEfundBatchDetail = new HashSet<RbcEfundBatchDetail>();
        }

        public int RbcEfundResponseCodeKey { get; set; }
        public string RbcCode { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }

        public virtual ICollection<RbcEfundBatchDetail> RbcEfundBatchDetail { get; set; }
    }
}
