using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class RolloverRequestDeclineReason
    {
        public RolloverRequestDeclineReason()
        {
            RolloverRequest = new HashSet<RolloverRequest>();
        }

        public int RolloverRequestDeclineReasonKey { get; set; }
        public string Description { get; set; }
        public bool IsEnabled { get; set; }

        public virtual ICollection<RolloverRequest> RolloverRequest { get; set; }
    }
}
