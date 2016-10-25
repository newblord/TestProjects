using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanPaymentWaiveRifee
    {
        public int LoanPaymentWaiveRiFeeKey { get; set; }
        public int LoanPaymentKey { get; set; }
        public string WaiveRiFeeReasonCode { get; set; }

        public virtual LoanPayment LoanPaymentKeyNavigation { get; set; }
    }
}
