using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanPaymentAddToQueue
    {
        public int LoanPaymentAddToQueueKey { get; set; }
        public int LoanPaymentKey { get; set; }
        public decimal AddToPaymentQueueAmt { get; set; }

        public virtual LoanPayment LoanPaymentKeyNavigation { get; set; }
    }
}
