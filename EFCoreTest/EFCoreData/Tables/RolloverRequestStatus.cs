using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class RolloverRequestStatus
    {
        public RolloverRequestStatus()
        {
            RolloverRequest = new HashSet<RolloverRequest>();
        }

        public int RolloverRequestStatusKey { get; set; }
        public int RolloverRequestStatusCode { get; set; }
        public string Description { get; set; }

        public virtual ICollection<RolloverRequest> RolloverRequest { get; set; }
    }
}
