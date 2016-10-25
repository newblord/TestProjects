using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class RbcEfundBatchDetail
    {
        public int RbcEfundBatchDetailKey { get; set; }
        public int RbcEfundBatchKey { get; set; }
        public int RbcEfundResponseCodeKey { get; set; }
        public int CustomerKey { get; set; }
        public int LoanKey { get; set; }
        public int IssuerKey { get; set; }
        public long BankId { get; set; }
        public string AcctNo { get; set; }
        public string Email { get; set; }
        public decimal Amount { get; set; }
        public bool Processed { get; set; }
        public bool Funded { get; set; }
        public bool Voided { get; set; }
        public int? RbcEfundBatchSummaryKey { get; set; }
        public string ResponseText { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Issuer IssuerKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
        public virtual RbcEfundBatch RbcEfundBatchKeyNavigation { get; set; }
        public virtual RbcEfundResponseCode RbcEfundResponseCodeKeyNavigation { get; set; }
    }
}
