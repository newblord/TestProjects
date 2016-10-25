using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class TitleLoanApproval
    {
        public int TitleloanApprovalKey { get; set; }
        public int TitleloanKey { get; set; }
        public decimal TlaWholesalePct { get; set; }
        public decimal TlaChkAcctPct { get; set; }
        public decimal TlaCcardPct { get; set; }
        public decimal TlaEmpSincePct { get; set; }
        public int TlaEmpSinceMon { get; set; }
        public decimal TlaBasePct { get; set; }
        public decimal TlaBaseAmt { get; set; }
        public decimal TlaNetIncAmt { get; set; }
        public bool TlaNetIncUsed { get; set; }
        public decimal TlaNetIncPct { get; set; }
        public decimal TlaWholeMinPct { get; set; }
        public decimal TlaWholeMinAmt { get; set; }
        public bool TlaWholeMinUsed { get; set; }
        public decimal TlaMaxLoanAmt { get; set; }
        public bool TlaMaxLoanUsed { get; set; }
        public bool TlaNetIncLimit { get; set; }
        public bool TlaFullIns1000 { get; set; }
        public bool TlaPayVer500 { get; set; }
        public bool TlaEmp3Mon500 { get; set; }
        public bool TlaMinLoan150 { get; set; }
        public bool TlaMaxNetInc25 { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public short EnteredLocation { get; set; }
        public bool? Tla2ndLienIncr { get; set; }
        public decimal Tla2ndLienIncrAmt { get; set; }
        public decimal? ApprovalAmt { get; set; }
        public decimal? MgrOverrideAmt { get; set; }
        public string MgrOverrideInits { get; set; }
        public int? LoanKey { get; set; }
        public int ScoreValue { get; set; }
        public decimal ScoreAmount { get; set; }

        public virtual TitleLoan TitleloanKeyNavigation { get; set; }
    }
}
