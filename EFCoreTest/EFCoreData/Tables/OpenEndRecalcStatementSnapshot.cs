using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OpenEndRecalcStatementSnapshot
    {
        public int OpenEndRecalcStatementSnapshotKey { get; set; }
        public int OpenEndLoanStatementSnapshotKey { get; set; }
        public string EnteredBy { get; set; }
        public DateTime DateEntered { get; set; }
        public decimal? PastDueTransFeeBal { get; set; }
        public decimal? CPastDueTransFeeBal { get; set; }
        public decimal? PastDueLienFeeBal { get; set; }
        public decimal? CPastDueLienFeeBal { get; set; }
        public decimal? PastDueCabFeeBal { get; set; }
        public decimal? CPastDueCabFeeBal { get; set; }
        public decimal? PastDueCollFeeBal { get; set; }
        public decimal? CPastDueCollFeeBal { get; set; }
        public decimal? PastDueCabLenderCollFeeBal { get; set; }
        public decimal? CPastDueCabLenderCollFeeBal { get; set; }
        public decimal? PastDueInterestBal { get; set; }
        public decimal? CPastDueInterestBal { get; set; }
        public decimal? PastDueCabLenderInterestBal { get; set; }
        public decimal? CPastDueCabLenderInterestBal { get; set; }
        public decimal? PastDuePrincBal { get; set; }
        public decimal? CPastDuePrincBal { get; set; }
        public decimal? CurrDueTransFeeBal { get; set; }
        public decimal? CCurrDueTransFeeBal { get; set; }
        public decimal? CurrDueLienFeeBal { get; set; }
        public decimal? CCurrDueLienFeeBal { get; set; }
        public decimal? CurrDueCabFeeBal { get; set; }
        public decimal? CCurrDueCabFeeBal { get; set; }
        public decimal? CurrDueInterestBal { get; set; }
        public decimal? CCurrDueInterestBal { get; set; }
        public decimal? CurrDueCabLenderInterestBal { get; set; }
        public decimal? CCurrDueCabLenderInterestBal { get; set; }
        public decimal? CurrDuePrincBal { get; set; }
        public decimal? CCurrDuePrincBal { get; set; }
        public decimal? NextDueTransFeeBal { get; set; }
        public decimal? CNextDueTransFeeBal { get; set; }
        public decimal? NextDueLienFeeBal { get; set; }
        public decimal? CNextDueLienFeeBal { get; set; }
        public decimal? NextDueCabFeeBal { get; set; }
        public decimal? CNextDueCabFeeBal { get; set; }
        public decimal? NextDueInterestBal { get; set; }
        public decimal? CNextDueInterestBal { get; set; }
        public decimal? NextDueCabLenderInterestBal { get; set; }
        public decimal? CNextDueCabLenderInterestBal { get; set; }
        public decimal? NextDuePrincBal { get; set; }
        public decimal? CNextDuePrincBal { get; set; }
        public decimal? NotDueTransFeeBal { get; set; }
        public decimal? CNotDueTransFeeBal { get; set; }
        public decimal? NotDueLienFeeBal { get; set; }
        public decimal? CNotDueLienFeeBal { get; set; }
        public decimal? NotDueCabFeeBal { get; set; }
        public decimal? CNotDueCabFeeBal { get; set; }
        public decimal? NotDueInterestBal { get; set; }
        public decimal? CNotDueInterestBal { get; set; }
        public decimal? NotDueCabLenderInterestBal { get; set; }
        public decimal? CNotDueCabLenderInterestBal { get; set; }
        public decimal? NotDuePrincBal { get; set; }
        public decimal? CNotDuePrincBal { get; set; }
        public DateTime? NextStatementDate { get; set; }
        public DateTime? CNextStatementDate { get; set; }
        public DateTime? NextDueDate { get; set; }
        public DateTime? CNextDueDate { get; set; }
        public decimal? PendingSchedAchAmt { get; set; }
        public decimal? CPendingSchedAchAmt { get; set; }
        public DateTime? PendingSchedAchSent { get; set; }
        public DateTime? CPendingSchedAchSent { get; set; }
        public decimal? PendingCollAchAmt { get; set; }
        public decimal? CPendingCollAchAmt { get; set; }
        public DateTime? PendingCollAchSent { get; set; }
        public DateTime? CPendingCollAchSent { get; set; }

        public virtual OpenEndLoanStatementSnapshot OpenEndLoanStatementSnapshotKeyNavigation { get; set; }
    }
}
