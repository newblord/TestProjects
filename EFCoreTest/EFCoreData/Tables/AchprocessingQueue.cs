using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AchprocessingQueue
    {
        public int AchProcessingQueueKey { get; set; }
        public int Location { get; set; }
        public int LoanKey { get; set; }
        public decimal AchAmount { get; set; }
        public DateTime DueDate { get; set; }
        public byte AchAttempt { get; set; }
        public DateTime? ManualSendDate { get; set; }
        public string ManualTeller { get; set; }
        public string AbaNo { get; set; }
        public string BankNo { get; set; }
        public bool IsScheduledPayment { get; set; }
        public bool IsAdAstra { get; set; }
        public bool IsAchPaid { get; set; }
        public int? JobId { get; set; }
        public short? AchReasonCode { get; set; }
        public int? OptplusCardDetailKey { get; set; }
        public string StatementId { get; set; }
        public decimal PrincAmtForInterestCredit { get; set; }
        public decimal FeesAmtForInterestCredit { get; set; }
        public decimal InterestDueCap { get; set; }
        public decimal CabInterestDueCap { get; set; }
        public int AchBankKey { get; set; }
        public string GradNumber { get; set; }
        public int AchProcessingTypeKey { get; set; }
        public int? AchSentParentKey { get; set; }
        public int RunMasterKey { get; set; }
        public int? SchedRolloverKey { get; set; }
        public int? AchPresentmentKey { get; set; }

        public virtual AchprocessingType AchProcessingTypeKeyNavigation { get; set; }
        public virtual Achreason AchReasonCodeNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
    }
}
