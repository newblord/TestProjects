using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PaydayLoanApproval
    {
        public int PaydayLoanApprovalKey { get; set; }
        public int LoanKey { get; set; }
        public int CustomerKey { get; set; }
        public decimal GrossIncomeAmt { get; set; }
        public decimal NetIncomeAmt { get; set; }
        public decimal OpenLoansPrincAmt { get; set; }
        public byte StateMaxPctOfIncome { get; set; }
        public string StateMaxNetOrGross { get; set; }
        public decimal StateMaxMultiLoanAmt { get; set; }
        public decimal StateMaxIncomeAmt { get; set; }
        public decimal StateMaxPerLoanAmt { get; set; }
        public decimal StateMaxAmt { get; set; }
        public bool ApprovalEnabled { get; set; }
        public byte ApprovalPctOfIncome { get; set; }
        public string ApprovalNetOrGross { get; set; }
        public decimal ApprovalBaseIncomeAmt { get; set; }
        public decimal ApprovalCcardAmt { get; set; }
        public decimal ApprovalDirDepAmt { get; set; }
        public decimal ApprovalSuccessfulAmt { get; set; }
        public decimal ApprovalBaseAmt { get; set; }
        public decimal MgrOverrideAmt { get; set; }
        public string MgrOverrideInits { get; set; }
        public decimal PrevPrincOverrideAmt { get; set; }
        public decimal ApprovalStateMaxAdjAmt { get; set; }
        public decimal ApprovalAmt { get; set; }
        public short ScoredIncrementAmount { get; set; }
        public short? ScoredIncrementNum { get; set; }
        public decimal IncludeFeeMaxPrincAmt { get; set; }
        public decimal IncludeFeeMaxLoanAmt { get; set; }

        public virtual Loan LoanKeyNavigation { get; set; }
    }
}
