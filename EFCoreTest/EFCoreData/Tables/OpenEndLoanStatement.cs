using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OpenEndLoanStatement
    {
        public OpenEndLoanStatement()
        {
            LoanDueDateChange = new HashSet<LoanDueDateChange>();
            OpenEndInterest = new HashSet<OpenEndInterest>();
            OpenEndRecalcStatementAdj = new HashSet<OpenEndRecalcStatementAdj>();
        }

        public int OpenEndLoanStmtKey { get; set; }
        public int TransDetailKey { get; set; }
        public int LoanPaymentKey { get; set; }
        public int LoanKey { get; set; }
        public int CustomerKey { get; set; }
        public DateTime DateEntered { get; set; }
        public short Location { get; set; }
        public byte StatementNum { get; set; }
        public decimal CreditLimit { get; set; }
        public decimal CreditAvail { get; set; }
        public decimal AvgDailyBal { get; set; }
        public decimal PerFinCharge { get; set; }
        public decimal? EffectiveApr { get; set; }
        public DateTime StartDate { get; set; }
        public decimal StartBalance { get; set; }
        public decimal StartPrinc { get; set; }
        public DateTime EndDate { get; set; }
        public decimal EndBalance { get; set; }
        public decimal EndPrinc { get; set; }
        public decimal PastDueAmt { get; set; }
        public DateTime? PastDueDate { get; set; }
        public decimal CurrDueTransFeeAmt { get; set; }
        public decimal CurrDueActivityFeeAmt { get; set; }
        public decimal CurrDueCollFeeAmt { get; set; }
        public decimal CurrDueInterestAmt { get; set; }
        public decimal CurrDuePrincAmt { get; set; }
        public decimal CurrDueAmt { get; set; }
        public DateTime CurrDueDate { get; set; }
        public decimal NextDueTransFeeAmt { get; set; }
        public decimal NextDueActivityFeeAmt { get; set; }
        public decimal NextDueCollFeeAmt { get; set; }
        public decimal NextDueInterestAmt { get; set; }
        public decimal NextDuePrincAmt { get; set; }
        public decimal NextDueAmt { get; set; }
        public DateTime NextDueDate { get; set; }
        public decimal NewTransFees { get; set; }
        public decimal NewLienFees { get; set; }
        public decimal NewActivityFees { get; set; }
        public decimal NewCollFees { get; set; }
        public decimal NewInterest { get; set; }
        public decimal NewLoanAmt { get; set; }
        public decimal NewPastDuePayments { get; set; }
        public decimal NewFeePayments { get; set; }
        public decimal NewInterestPayments { get; set; }
        public decimal NewPrincPayments { get; set; }
        public decimal NewPayments { get; set; }
        public decimal TotTransFees { get; set; }
        public decimal TotLienFees { get; set; }
        public decimal TotActivityFees { get; set; }
        public decimal TotCollFees { get; set; }
        public decimal TotInterest { get; set; }
        public decimal TotLoanAmt { get; set; }
        public decimal TotPayments { get; set; }
        public decimal YtdTransFeesAmt { get; set; }
        public decimal YtdActivityFeesAmt { get; set; }
        public decimal YtdCollFeesAmt { get; set; }
        public decimal YtdInterestAmt { get; set; }
        public byte MailStatus { get; set; }
        public bool MailedWithImage { get; set; }
        public decimal CurrDueCsoLenderInterestAmt { get; set; }
        public decimal NextDueCsoLenderInterestAmt { get; set; }
        public decimal NewCsoLenderInterest { get; set; }
        public decimal TotCsoLenderInterest { get; set; }
        public decimal YtdCsoLenderInterestAmt { get; set; }
        public decimal NewCsoLenderInterestPayments { get; set; }
        public bool IsFinalStatement { get; set; }
        public DateTime AdjustedDueDate { get; set; }
        public decimal FinalEstDueInterestAmt { get; set; }
        public decimal FinalEstDueCsoLenderInterestAmt { get; set; }
        public int? OpenEndLoanStatementSnapshotKey { get; set; }

        public virtual ICollection<LoanDueDateChange> LoanDueDateChange { get; set; }
        public virtual ICollection<OpenEndInterest> OpenEndInterest { get; set; }
        public virtual ICollection<OpenEndRecalcStatementAdj> OpenEndRecalcStatementAdj { get; set; }
        public virtual LoanPayment LoanPaymentKeyNavigation { get; set; }
        public virtual OpenEndLoanStatementSnapshot OpenEndLoanStatementSnapshotKeyNavigation { get; set; }
        public virtual TransDetail TransDetailKeyNavigation { get; set; }
    }
}
