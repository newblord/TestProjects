using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PrepaidCardStopPaymentEdit
    {
        public int PrepaidCardStopPaymentEditKey { get; set; }
        public int PrepaidCardStopPaymentKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }

        public virtual PrepaidCardStopPayment PrepaidCardStopPaymentKeyNavigation { get; set; }
    }
}
