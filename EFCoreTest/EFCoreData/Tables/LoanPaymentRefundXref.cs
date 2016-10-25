using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanPaymentRefundXref
    {
        public LoanPaymentRefundXref()
        {
            LoanPaymentMpayRefund = new HashSet<LoanPaymentMpayRefund>();
            LoanPaymentOpenEndRefund = new HashSet<LoanPaymentOpenEndRefund>();
            LoanPaymentSpayRefund = new HashSet<LoanPaymentSpayRefund>();
        }

        public int LoanPaymentRefundXrefKey { get; set; }
        public int RefundLoanPaymentKey { get; set; }
        public int RefundedLoanPaymentKey { get; set; }
        public decimal RefundAmount { get; set; }

        public virtual ICollection<LoanPaymentMpayRefund> LoanPaymentMpayRefund { get; set; }
        public virtual ICollection<LoanPaymentOpenEndRefund> LoanPaymentOpenEndRefund { get; set; }
        public virtual ICollection<LoanPaymentSpayRefund> LoanPaymentSpayRefund { get; set; }
        public virtual LoanPayment RefundLoanPaymentKeyNavigation { get; set; }
        public virtual LoanPayment RefundedLoanPaymentKeyNavigation { get; set; }
    }
}
