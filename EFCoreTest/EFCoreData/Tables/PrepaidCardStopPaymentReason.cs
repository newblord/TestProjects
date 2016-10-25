using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PrepaidCardStopPaymentReason
    {
        public PrepaidCardStopPaymentReason()
        {
            PrepaidCardStopPayment = new HashSet<PrepaidCardStopPayment>();
        }

        public int PrepaidCardStopPaymentReasonKey { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public bool AllowOtherNote { get; set; }

        public virtual ICollection<PrepaidCardStopPayment> PrepaidCardStopPayment { get; set; }
    }
}
