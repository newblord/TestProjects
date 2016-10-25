using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class SpayLoanInSyncAdj
    {
        public int SpayLoanInSyncAdjKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public int LoanKey { get; set; }
        public decimal LoanAmt { get; set; }
        public decimal PrincAmt { get; set; }
        public decimal CashAmt { get; set; }
        public decimal LoanFeeAmt { get; set; }
        public decimal LienFeeAmt { get; set; }
        public bool ChargeLienFee { get; set; }
        public string LoanStatus { get; set; }
        public decimal LoanBalance { get; set; }
        public decimal RiBalance { get; set; }
        public bool Defaulted { get; set; }
        public DateTime? DefaultDate { get; set; }
        public DateTime? PendingSchedAchSent { get; set; }
        public decimal PendingSchedAchAmt { get; set; }
        public decimal CollFeeBalance { get; set; }
        public decimal LegalFeeBalance { get; set; }
        public decimal LoanFeeBalance { get; set; }
        public decimal InterestBalance { get; set; }
        public decimal PrincBalance { get; set; }
        public decimal TotalInterestAmt { get; set; }
        public decimal? InventoryAmt { get; set; }
        public decimal CLoanAmt { get; set; }
        public decimal CPrincAmt { get; set; }
        public decimal CCashAmt { get; set; }
        public decimal CLoanFeeAmt { get; set; }
        public decimal CLienFeeAmt { get; set; }
        public bool CChargeLienFee { get; set; }
        public string CLoanStatus { get; set; }
        public decimal CLoanBalance { get; set; }
        public decimal CRiBalance { get; set; }
        public bool CDefaulted { get; set; }
        public DateTime? CDefaultDate { get; set; }
        public DateTime? CPendingSchedAchSent { get; set; }
        public decimal CPendingSchedAchAmt { get; set; }
        public decimal CCollFeeBalance { get; set; }
        public decimal CLegalFeeBalance { get; set; }
        public decimal CLoanFeeBalance { get; set; }
        public decimal CInterestBalance { get; set; }
        public decimal CPrincBalance { get; set; }
        public decimal CTotalInterestAmt { get; set; }
        public decimal? CInventoryAmt { get; set; }
        public int CAdjCntInt { get; set; }
        public int CAdjCntLpSpayRecord { get; set; }
        public decimal CabInterestBalance { get; set; }
        public decimal TotCabInterest { get; set; }
        public decimal CCabInterestBalance { get; set; }
        public decimal CTotCabInterest { get; set; }
        public decimal CabLenderCollFeePastDueBalance { get; set; }
        public decimal CCabLenderCollFeePastDueBalance { get; set; }
        public decimal NsfFeeDueBalance { get; set; }
        public decimal CNsfFeeDueBalance { get; set; }
        public bool? IsInLegalStatus { get; set; }
    }
}
