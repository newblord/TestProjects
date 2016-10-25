using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OpenEndRecalcLoanPaymentAdj
    {
        public int OpenEndRecalcLoanPaymentAdjKey { get; set; }
        public int LoanPaymentKey { get; set; }
        public int LoanKey { get; set; }
        public string EnteredBy { get; set; }
        public DateTime DateEntered { get; set; }
        public byte? Transcode { get; set; }
        public byte CTranscode { get; set; }
        public decimal PastDueTransFeeAmt { get; set; }
        public decimal CPastDueTransFeeAmt { get; set; }
        public decimal PastDueLienFeeAmt { get; set; }
        public decimal CPastDueLienFeeAmt { get; set; }
        public decimal PastDueActivityFeeAmt { get; set; }
        public decimal CPastDueActivityFeeAmt { get; set; }
        public decimal PastDueCollFeeAmt { get; set; }
        public decimal CPastDueCollFeeAmt { get; set; }
        public decimal PastDueInterestAmt { get; set; }
        public decimal CPastDueInterestAmt { get; set; }
        public decimal PastDuePrincAmt { get; set; }
        public decimal CPastDuePrincAmt { get; set; }
        public decimal PastDueCsoLenderCollFeeAmt { get; set; }
        public decimal CPastDueCsoLenderCollFeeAmt { get; set; }
        public decimal PastDueCsoLenderInterestAmt { get; set; }
        public decimal CPastDueCsoLenderInterestAmt { get; set; }
        public decimal CurrDueTransFeeAmt { get; set; }
        public decimal CCurrDueTransFeeAmt { get; set; }
        public decimal CurrDueLienFeeAmt { get; set; }
        public decimal CCurrDueLienFeeAmt { get; set; }
        public decimal CurrDueActivityFeeAmt { get; set; }
        public decimal CCurrDueActivityFeeAmt { get; set; }
        public decimal CurrDueInterestAmt { get; set; }
        public decimal CCurrDueInterestAmt { get; set; }
        public decimal CurrDuePrincAmt { get; set; }
        public decimal CCurrDuePrincAmt { get; set; }
        public decimal CurrDueCsoLenderInterestAmt { get; set; }
        public decimal CCurrDueCsoLenderInterestAmt { get; set; }
        public decimal NextDueTransFeeAmt { get; set; }
        public decimal CNextDueTransFeeAmt { get; set; }
        public decimal NextDueLienFeeAmt { get; set; }
        public decimal CNextDueLienFeeAmt { get; set; }
        public decimal NextDueActivityFeeAmt { get; set; }
        public decimal CNextDueActivityFeeAmt { get; set; }
        public decimal NextDueInterestAmt { get; set; }
        public decimal CNextDueInterestAmt { get; set; }
        public decimal NextDuePrincAmt { get; set; }
        public decimal CNextDuePrincAmt { get; set; }
        public decimal NextDueCsoLenderInterestAmt { get; set; }
        public decimal CNextDueCsoLenderInterestAmt { get; set; }
        public decimal NotDueTransFeeAmt { get; set; }
        public decimal CNotDueTransFeeAmt { get; set; }
        public decimal NotDueLienFeeAmt { get; set; }
        public decimal CNotDueLienFeeAmt { get; set; }
        public decimal NotDueActivityFeeAmt { get; set; }
        public decimal CNotDueActivityFeeAmt { get; set; }
        public decimal NotDueInterestAmt { get; set; }
        public decimal CNotDueInterestAmt { get; set; }
        public decimal NotDuePrincAmt { get; set; }
        public decimal CNotDuePrincAmt { get; set; }
        public decimal NotDueCsoLenderInterestAmt { get; set; }
        public decimal CNotDueCsoLenderInterestAmt { get; set; }
        public bool AddToColl { get; set; }
        public bool CAddToColl { get; set; }
        public bool RemFromColl { get; set; }
        public bool CRemFromColl { get; set; }
        public decimal PendingSchedAchAmt { get; set; }
        public decimal CPendingSchedAchAmt { get; set; }
        public DateTime? LpddOrigDueDate { get; set; }
        public DateTime? CLpddOrigDueDate { get; set; }
        public DateTime? LpddAdjustedDueDate { get; set; }
        public DateTime? CLpddAdjustedDueDate { get; set; }
        public decimal LpddPastDueAmt { get; set; }
        public decimal CLpddPastDueAmt { get; set; }
        public decimal LpddCollectionsAmt { get; set; }
        public decimal CLpddCollectionsAmt { get; set; }
        public decimal LpddPendingAchAmt { get; set; }
        public decimal CLpddPendingAchAmt { get; set; }
    }
}
