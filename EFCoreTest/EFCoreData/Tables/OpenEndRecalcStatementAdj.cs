﻿using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OpenEndRecalcStatementAdj
    {
        public int OpenEndRecalcStatementAdjKey { get; set; }
        public int OpenEndLoanStmtKey { get; set; }
        public string EnteredBy { get; set; }
        public DateTime DateEntered { get; set; }
        public decimal CreditLimit { get; set; }
        public decimal CCreditLimit { get; set; }
        public decimal CreditAvail { get; set; }
        public decimal CCreditAvail { get; set; }
        public decimal AvgDailyBal { get; set; }
        public decimal CAvgDailyBal { get; set; }
        public decimal PerFinCharge { get; set; }
        public decimal CPerFinCharge { get; set; }
        public decimal? EffectiveApr { get; set; }
        public decimal? CEffectiveApr { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CStartDate { get; set; }
        public decimal StartBalance { get; set; }
        public decimal CStartBalance { get; set; }
        public decimal StartPrinc { get; set; }
        public decimal CStartPrinc { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CEndDate { get; set; }
        public decimal EndBalance { get; set; }
        public decimal CEndBalance { get; set; }
        public decimal EndPrinc { get; set; }
        public decimal CEndPrinc { get; set; }
        public decimal PastDueAmt { get; set; }
        public decimal CPastDueAmt { get; set; }
        public DateTime? PastDueDate { get; set; }
        public DateTime? CPastDueDate { get; set; }
        public decimal CurrDueTransFeeAmt { get; set; }
        public decimal CCurrDueTransFeeAmt { get; set; }
        public decimal CurrDueActivityFeeAmt { get; set; }
        public decimal CCurrDueActivityFeeAmt { get; set; }
        public decimal CurrDueCollFeeAmt { get; set; }
        public decimal CCurrDueCollFeeAmt { get; set; }
        public decimal CurrDueInterestAmt { get; set; }
        public decimal CCurrDueInterestAmt { get; set; }
        public decimal CurrDuePrincAmt { get; set; }
        public decimal CCurrDuePrincAmt { get; set; }
        public decimal CurrDueAmt { get; set; }
        public decimal CCurrDueAmt { get; set; }
        public DateTime CurrDueDate { get; set; }
        public DateTime CCurrDueDate { get; set; }
        public decimal NextDueTransFeeAmt { get; set; }
        public decimal CNextDueTransFeeAmt { get; set; }
        public decimal NextDueActivityFeeAmt { get; set; }
        public decimal CNextDueActivityFeeAmt { get; set; }
        public decimal NextDueCollFeeAmt { get; set; }
        public decimal CNextDueCollFeeAmt { get; set; }
        public decimal NextDueInterestAmt { get; set; }
        public decimal CNextDueInterestAmt { get; set; }
        public decimal NextDuePrincAmt { get; set; }
        public decimal CNextDuePrincAmt { get; set; }
        public decimal NextDueAmt { get; set; }
        public decimal CNextDueAmt { get; set; }
        public DateTime NextDueDate { get; set; }
        public DateTime CNextDueDate { get; set; }
        public decimal NewTransFees { get; set; }
        public decimal CNewTransFees { get; set; }
        public decimal NewLienFees { get; set; }
        public decimal CNewLienFees { get; set; }
        public decimal NewActivityFees { get; set; }
        public decimal CNewActivityFees { get; set; }
        public decimal NewCollFees { get; set; }
        public decimal CNewCollFees { get; set; }
        public decimal NewInterest { get; set; }
        public decimal CNewInterest { get; set; }
        public decimal NewLoanAmt { get; set; }
        public decimal CNewLoanAmt { get; set; }
        public decimal NewPastDuePayments { get; set; }
        public decimal CNewPastDuePayments { get; set; }
        public decimal NewFeePayments { get; set; }
        public decimal CNewFeePayments { get; set; }
        public decimal NewInterestPayments { get; set; }
        public decimal CNewInterestPayments { get; set; }
        public decimal NewPrincPayments { get; set; }
        public decimal CNewPrincPayments { get; set; }
        public decimal NewPayments { get; set; }
        public decimal CNewPayments { get; set; }
        public decimal TotTransFees { get; set; }
        public decimal CTotTransFees { get; set; }
        public decimal TotLienFees { get; set; }
        public decimal CTotLienFees { get; set; }
        public decimal TotActivityFees { get; set; }
        public decimal CTotActivityFees { get; set; }
        public decimal TotCollFees { get; set; }
        public decimal CTotCollFees { get; set; }
        public decimal TotInterest { get; set; }
        public decimal CTotInterest { get; set; }
        public decimal TotLoanAmt { get; set; }
        public decimal CTotLoanAmt { get; set; }
        public decimal TotPayments { get; set; }
        public decimal CTotPayments { get; set; }
        public decimal YtdTransFeesAmt { get; set; }
        public decimal CYtdTransFeesAmt { get; set; }
        public decimal YtdActivityFeesAmt { get; set; }
        public decimal CYtdActivityFeesAmt { get; set; }
        public decimal YtdCollFeesAmt { get; set; }
        public decimal CYtdCollFeesAmt { get; set; }
        public decimal YtdInterestAmt { get; set; }
        public decimal CYtdInterestAmt { get; set; }
        public decimal CurrDueCsoLenderInterestAmt { get; set; }
        public decimal CCurrDueCsoLenderInterestAmt { get; set; }
        public decimal NextDueCsoLenderInterestAmt { get; set; }
        public decimal CNextDueCsoLenderInterestAmt { get; set; }
        public decimal NewCsoLenderInterest { get; set; }
        public decimal CNewCsoLenderInterest { get; set; }
        public decimal TotCsoLenderInterest { get; set; }
        public decimal CTotCsoLenderInterest { get; set; }
        public decimal YtdCsoLenderInterestAmt { get; set; }
        public decimal CYtdCsoLenderInterestAmt { get; set; }
        public decimal NewCsoLenderInterestPayments { get; set; }
        public decimal CNewCsoLenderInterestPayments { get; set; }
        public bool IsFinalStatement { get; set; }
        public bool CIsFinalStatement { get; set; }
        public DateTime AdjustedDueDate { get; set; }
        public DateTime CAdjustedDueDate { get; set; }
        public decimal FinalEstDueInterestAmt { get; set; }
        public decimal CFinalEstDueInterestAmt { get; set; }
        public decimal FinalEstDueCsoLenderInterestAmt { get; set; }
        public decimal CFinalEstDueCsoLenderInterestAmt { get; set; }

        public virtual OpenEndLoanStatement OpenEndLoanStmtKeyNavigation { get; set; }
    }
}
