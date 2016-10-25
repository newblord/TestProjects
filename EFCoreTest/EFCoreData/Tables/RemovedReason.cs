using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class RemovedReason
    {
        public RemovedReason()
        {
            CustomerAddress = new HashSet<CustomerAddress>();
        }

        public byte RemovedReasonKey { get; set; }
        public string Reason { get; set; }

        public virtual ICollection<CustomerAddress> CustomerAddress { get; set; }
    }
}
