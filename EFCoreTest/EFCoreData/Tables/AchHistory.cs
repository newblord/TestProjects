using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AchHistory
    {
        public AchHistory()
        {
            UddreportDetail = new HashSet<UddreportDetail>();
        }

        public int AchHistoryKey { get; set; }
        public int CustomerKey { get; set; }
        public short Location { get; set; }
        public int? LoanKey { get; set; }
        public decimal? AchAmount { get; set; }
        public byte AchAttempt { get; set; }
        public DateTime ProjSendDate { get; set; }
        public DateTime? ManualSendDate { get; set; }
        public string ManualTeller { get; set; }
        public int AchSentKey { get; set; }
        public int? AchRecvKey { get; set; }
        public string AchResultCode { get; set; }
        public DateTime DateEntered { get; set; }
        public string AbaNo { get; set; }
        public string BankNo { get; set; }
        public int Jobid { get; set; }
        public int? TransDetailKey { get; set; }
        public int? SendLoanPaymentKey { get; set; }
        public int? RecvLoanPaymentKey { get; set; }
        public bool IsAdAstra { get; set; }
        public bool IsAchPaid { get; set; }
        public int? RefundLoanPaymentKey { get; set; }
        public short? AchReasonCode { get; set; }
        public int? OptplusCardDetailKey { get; set; }
        public string StatementId { get; set; }
        public decimal PrincAmtForInterestCredit { get; set; }
        public decimal FeesAmtForInterestCredit { get; set; }
        public decimal InterestDueCap { get; set; }
        public decimal CabInterestDueCap { get; set; }
        public bool SchedPayment { get; set; }
        public bool IsCredit { get; set; }
        public int? AchPresentmentKey { get; set; }

        public virtual Ddiachhistory Ddiachhistory { get; set; }
        public virtual ICollection<UddreportDetail> UddreportDetail { get; set; }
        public virtual Achreason AchReasonCodeNavigation { get; set; }
        public virtual AchRecv AchRecvKeyNavigation { get; set; }
        public virtual AchReturnCode AchResultCodeNavigation { get; set; }
        public virtual AchSent AchSentKeyNavigation { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
        public virtual LoanPayment RecvLoanPaymentKeyNavigation { get; set; }
        public virtual LoanPayment RefundLoanPaymentKeyNavigation { get; set; }
        public virtual LoanPayment SendLoanPaymentKeyNavigation { get; set; }
    }
}
