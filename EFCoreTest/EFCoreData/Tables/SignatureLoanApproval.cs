using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class SignatureLoanApproval
    {
        public int SignatureLoanApprovalKey { get; set; }
        public int LoanKey { get; set; }
        public int CustomerKey { get; set; }
        public decimal GrossIncomeAmt { get; set; }
        public decimal NetIncomeAmt { get; set; }
        public decimal OpenLoansPrincAmt { get; set; }
        public decimal ApprovalBaseIncomeAmt { get; set; }
        public decimal ApprovalSuccessfulAmt { get; set; }
        public decimal ApprovalBaseAmt { get; set; }
        public decimal MgrOverrideAmt { get; set; }
        public string MgrOverrideInits { get; set; }
        public decimal PrevPrincOverrideAmt { get; set; }
        public decimal ApprovalAmt { get; set; }
        public short ScoredIncrementAmount { get; set; }
        public short? ScoredIncrementNum { get; set; }

        public virtual Loan LoanKeyNavigation { get; set; }
    }
}
