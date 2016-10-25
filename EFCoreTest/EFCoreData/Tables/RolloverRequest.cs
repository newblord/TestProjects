using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class RolloverRequest
    {
        public int RolloverRequestKey { get; set; }
        public int LoanKey { get; set; }
        public byte RequestSource { get; set; }
        public short? CcLastFour { get; set; }
        public int? CreditCardKey { get; set; }
        public int? SmsInboundKey { get; set; }
        public string EnteredBy { get; set; }
        public DateTime EnteredDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool HaveFinancialsChanged { get; set; }
        public string DeferralReason { get; set; }
        public DateTime? NextPayDate { get; set; }
        public int RolloverRequestStatusKey { get; set; }
        public int? RolloverRequestDeclineReasonKey { get; set; }

        public virtual LoanApplicationAffordSurveyToBeDeleted LoanApplicationAffordSurveyToBeDeleted { get; set; }
        public virtual LoanApplicationExpense LoanApplicationExpense { get; set; }
        public virtual CreditCards CreditCardKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
        public virtual RolloverRequestDeclineReason RolloverRequestDeclineReasonKeyNavigation { get; set; }
        public virtual RolloverRequestStatus RolloverRequestStatusKeyNavigation { get; set; }
        public virtual Smsinbound SmsInboundKeyNavigation { get; set; }
    }
}
