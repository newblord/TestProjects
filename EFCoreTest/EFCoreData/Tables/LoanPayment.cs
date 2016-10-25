using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanPayment
    {
        public LoanPayment()
        {
            AchHistoryRecvLoanPaymentKeyNavigation = new HashSet<AchHistory>();
            AchHistoryRefundLoanPaymentKeyNavigation = new HashSet<AchHistory>();
            AchHistorySendLoanPaymentKeyNavigation = new HashSet<AchHistory>();
            AttorneyPayment = new HashSet<AttorneyPayment>();
            LoanFunding = new HashSet<LoanFunding>();
            LoanPaymentDecreaseAmountOwed = new HashSet<LoanPaymentDecreaseAmountOwed>();
            LoanPaymentDueDate = new HashSet<LoanPaymentDueDate>();
            LoanPaymentInsuranceClaimXref = new HashSet<LoanPaymentInsuranceClaimXref>();
            LoanPaymentMpay = new HashSet<LoanPaymentMpay>();
            LoanPaymentOpenEnd = new HashSet<LoanPaymentOpenEnd>();
            LoanPaymentRefundXrefRefundLoanPaymentKeyNavigation = new HashSet<LoanPaymentRefundXref>();
            LoanPaymentRefundXrefRefundedLoanPaymentKeyNavigation = new HashSet<LoanPaymentRefundXref>();
            LoanPaymentRescindCashAdvanceLoanPaymentKeyNavigation = new HashSet<LoanPaymentRescind>();
            LoanPaymentRescindLoanPaymentKeyNavigation = new HashSet<LoanPaymentRescind>();
            LoanPaymentSpay = new HashSet<LoanPaymentSpay>();
            LoanPaymentSuspendInterestLoanPaymentResumeKeyNavigation = new HashSet<LoanPaymentSuspendInterest>();
            LoanPaymentSuspendInterestLoanPaymentSuspendKeyNavigation = new HashSet<LoanPaymentSuspendInterest>();
            LoanPaymentWaiveRifee = new HashSet<LoanPaymentWaiveRifee>();
            OpenEndLoanStatement = new HashSet<OpenEndLoanStatement>();
        }

        public int LoanpaymentKey { get; set; }
        public int PaidLoanKey { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public string Note { get; set; }
        public decimal PaidAmt { get; set; }
        public bool Reversed { get; set; }
        public DateTime? ReversedDate { get; set; }
        public short PaymentMethod { get; set; }
        public int TransDetailKey { get; set; }
        public byte TransCode { get; set; }
        public string ProductType { get; set; }
        public string LoanType { get; set; }
        public int LoanKey { get; set; }
        public int LoanPaymentKey { get; set; }

        public virtual ICollection<AchHistory> AchHistoryRecvLoanPaymentKeyNavigation { get; set; }
        public virtual ICollection<AchHistory> AchHistoryRefundLoanPaymentKeyNavigation { get; set; }
        public virtual ICollection<AchHistory> AchHistorySendLoanPaymentKeyNavigation { get; set; }
        public virtual ICollection<AttorneyPayment> AttorneyPayment { get; set; }
        public virtual ICollection<LoanFunding> LoanFunding { get; set; }
        public virtual LoanPaymentAddToQueue LoanPaymentAddToQueue { get; set; }
        public virtual ICollection<LoanPaymentDecreaseAmountOwed> LoanPaymentDecreaseAmountOwed { get; set; }
        public virtual ICollection<LoanPaymentDueDate> LoanPaymentDueDate { get; set; }
        public virtual ICollection<LoanPaymentInsuranceClaimXref> LoanPaymentInsuranceClaimXref { get; set; }
        public virtual ICollection<LoanPaymentMpay> LoanPaymentMpay { get; set; }
        public virtual ICollection<LoanPaymentOpenEnd> LoanPaymentOpenEnd { get; set; }
        public virtual ICollection<LoanPaymentRefundXref> LoanPaymentRefundXrefRefundLoanPaymentKeyNavigation { get; set; }
        public virtual ICollection<LoanPaymentRefundXref> LoanPaymentRefundXrefRefundedLoanPaymentKeyNavigation { get; set; }
        public virtual ICollection<LoanPaymentRescind> LoanPaymentRescindCashAdvanceLoanPaymentKeyNavigation { get; set; }
        public virtual ICollection<LoanPaymentRescind> LoanPaymentRescindLoanPaymentKeyNavigation { get; set; }
        public virtual ICollection<LoanPaymentSpay> LoanPaymentSpay { get; set; }
        public virtual ICollection<LoanPaymentSuspendInterest> LoanPaymentSuspendInterestLoanPaymentResumeKeyNavigation { get; set; }
        public virtual ICollection<LoanPaymentSuspendInterest> LoanPaymentSuspendInterestLoanPaymentSuspendKeyNavigation { get; set; }
        public virtual ICollection<LoanPaymentWaiveRifee> LoanPaymentWaiveRifee { get; set; }
        public virtual ICollection<OpenEndLoanStatement> OpenEndLoanStatement { get; set; }
        public virtual Company LocationNavigation { get; set; }
        public virtual Loan PaidLoanKeyNavigation { get; set; }
        public virtual TransDetail TransDetailKeyNavigation { get; set; }
    }
}
