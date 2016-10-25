using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CashedCheckPaymentRefundXref
    {
        public int CashedCheckPaymentRefundXrefKey { get; set; }
        public int RefundCashedCheckPaymentKey { get; set; }
        public int RefundedCashedCheckPaymentKey { get; set; }
        public decimal RefundAmount { get; set; }

        public virtual CashedCheckPayment RefundCashedCheckPaymentKeyNavigation { get; set; }
        public virtual CashedCheckPayment RefundedCashedCheckPaymentKeyNavigation { get; set; }
    }
}
