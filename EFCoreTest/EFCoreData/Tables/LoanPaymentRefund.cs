using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanPaymentRefund
    {
        public int LoanPaymentRefundKey { get; set; }
        public int TransDetailKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public short Location { get; set; }
        public bool Reversed { get; set; }
        public int? ReverseTransDetailKey { get; set; }
        public int RefundedLoanPaymentKey { get; set; }
        public decimal Amount { get; set; }
        public bool IsChargebackToCollections { get; set; }
        public int? RefundedTransDetailKey { get; set; }
    }
}
