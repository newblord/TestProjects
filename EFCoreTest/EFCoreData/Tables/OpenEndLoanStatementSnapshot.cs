using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OpenEndLoanStatementSnapshot
    {
        public OpenEndLoanStatementSnapshot()
        {
            OpenEndLoanStatement = new HashSet<OpenEndLoanStatement>();
            OpenEndRecalcStatementSnapshot = new HashSet<OpenEndRecalcStatementSnapshot>();
        }

        public int OpenEndLoanStatementSnapshotKey { get; set; }
        public decimal PastDueTransFeeBal { get; set; }
        public decimal PastDueLienFeeBal { get; set; }
        public decimal PastDueCabFeeBal { get; set; }
        public decimal PastDueCollFeeBal { get; set; }
        public decimal PastDueCabLenderCollFeeBal { get; set; }
        public decimal PastDueInterestBal { get; set; }
        public decimal PastDueCabLenderInterestBal { get; set; }
        public decimal PastDuePrincBal { get; set; }
        public decimal CurrDueTransFeeBal { get; set; }
        public decimal CurrDueLienFeeBal { get; set; }
        public decimal CurrDueCabFeeBal { get; set; }
        public decimal CurrDueInterestBal { get; set; }
        public decimal CurrDueCabLenderInterestBal { get; set; }
        public decimal CurrDuePrincBal { get; set; }
        public decimal NextDueTransFeeBal { get; set; }
        public decimal NextDueLienFeeBal { get; set; }
        public decimal NextDueCabFeeBal { get; set; }
        public decimal NextDueInterestBal { get; set; }
        public decimal NextDueCabLenderInterestBal { get; set; }
        public decimal NextDuePrincBal { get; set; }
        public decimal NotDueTransFeeBal { get; set; }
        public decimal NotDueLienFeeBal { get; set; }
        public decimal NotDueCabFeeBal { get; set; }
        public decimal NotDueInterestBal { get; set; }
        public decimal NotDueCabLenderInterestBal { get; set; }
        public decimal NotDuePrincBal { get; set; }
        public decimal? TransFeeBal { get; set; }
        public decimal? LienFeeBal { get; set; }
        public decimal? CabFeeBal { get; set; }
        public decimal? CabLenderInterestFeeBal { get; set; }
        public decimal? InterestBal { get; set; }
        public decimal? PrincBal { get; set; }
        public decimal? PastDueBal { get; set; }
        public decimal? CurrDueBal { get; set; }
        public decimal? NextDueBal { get; set; }
        public decimal? NotDueBal { get; set; }
        public DateTime? NextStatementDate { get; set; }
        public DateTime? NextDueDate { get; set; }
        public decimal PendingSchedAchAmt { get; set; }
        public DateTime? PendingSchedAchSent { get; set; }
        public decimal PendingCollAchAmt { get; set; }
        public DateTime? PendingCollAchSent { get; set; }

        public virtual ICollection<OpenEndLoanStatement> OpenEndLoanStatement { get; set; }
        public virtual ICollection<OpenEndRecalcStatementSnapshot> OpenEndRecalcStatementSnapshot { get; set; }
    }
}
