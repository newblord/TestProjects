using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CashedCheckPaymentRefund
    {
        public int CashedCheckPaymentRefundKey { get; set; }
        public int TransDetailKey { get; set; }
        public int RefundedCashedCheckPaymentKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public short Location { get; set; }
        public bool Reversed { get; set; }
        public int? ReverseTransDetailKey { get; set; }

        public virtual CashedCheckPayment RefundedCashedCheckPaymentKeyNavigation { get; set; }
        public virtual TransDetail TransDetailKeyNavigation { get; set; }
    }
}
