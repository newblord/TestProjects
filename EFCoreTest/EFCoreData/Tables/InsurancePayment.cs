using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class InsurancePayment
    {
        public int InsurancePaymentKey { get; set; }
        public int InsurancePaymentBatchKey { get; set; }
        public int LoanKey { get; set; }
        public int InsuranceClaimKey { get; set; }
        public int TransDetailKey { get; set; }
        public decimal PaidAmt { get; set; }
        public bool PastDueBalWaived { get; set; }

        public virtual InsuranceClaim InsuranceClaimKeyNavigation { get; set; }
        public virtual InsurancePaymentBatch InsurancePaymentBatchKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
        public virtual TransDetail TransDetailKeyNavigation { get; set; }
    }
}
