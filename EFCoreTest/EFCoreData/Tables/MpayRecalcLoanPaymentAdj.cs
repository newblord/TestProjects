using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class MpayRecalcLoanPaymentAdj
    {
        public int MpayRecalcLoanPaymentAdjKey { get; set; }
        public int LoanPaymentKey { get; set; }
        public int LoanKey { get; set; }
        public string EnteredBy { get; set; }
        public DateTime DateEntered { get; set; }
        public byte? Transcode { get; set; }
        public byte CTranscode { get; set; }
        public bool AddToColl { get; set; }
        public bool CAddToColl { get; set; }
        public bool RemFromColl { get; set; }
        public bool CRemFromColl { get; set; }
        public decimal PendingSchedAchAmt { get; set; }
        public decimal CPendingSchedAchAmt { get; set; }
        public decimal CollFeePastDuePaid { get; set; }
        public decimal CCollFeePastDuePaid { get; set; }
        public decimal LegalFeePastDuePaid { get; set; }
        public decimal CLegalFeePastDuePaid { get; set; }
        public decimal LoanFeeDuePaid { get; set; }
        public decimal CLoanFeeDuePaid { get; set; }
        public decimal TransFeeDuePaid { get; set; }
        public decimal CTransFeeDuePaid { get; set; }
        public decimal InterestDuePaid { get; set; }
        public decimal CInterestDuePaid { get; set; }
        public decimal PrincDuePaid { get; set; }
        public decimal CPrincDuePaid { get; set; }
        public decimal PaymentDuePaid { get; set; }
        public decimal CPaymentDuePaid { get; set; }
        public decimal PaymentPastDuePaid { get; set; }
        public decimal CPaymentPastDuePaid { get; set; }
        public decimal CabCollFeePastDuePaid { get; set; }
        public decimal CCabCollFeePastDuePaid { get; set; }
        public decimal CabInterestDuePaid { get; set; }
        public decimal CCabInterestDuePaid { get; set; }
        public decimal NsfFeePastDuePaid { get; set; }
        public decimal CNsfFeePastDuePaid { get; set; }
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
        public decimal InsuranceDuePaid { get; set; }
        public decimal CInsuranceDuePaid { get; set; }
    }
}
