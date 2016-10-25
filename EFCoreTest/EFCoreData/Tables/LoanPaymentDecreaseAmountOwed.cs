using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanPaymentDecreaseAmountOwed
    {
        public int LoanPaymentDecreaseAmountOwedKey { get; set; }
        public int LoanPaymentKey { get; set; }
        public string DecreaseAmountOwedType { get; set; }
        public string DecreaseAmountOwedReason { get; set; }
        public decimal ApplyBucketAmt { get; set; }
        public string ApplyDueType { get; set; }
        public string ApplyBucketType { get; set; }

        public virtual LoanPayment LoanPaymentKeyNavigation { get; set; }
    }
}
