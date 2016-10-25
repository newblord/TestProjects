using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Loan
    {
        public Loan()
        {
            AchprocessingQueue = new HashSet<AchprocessingQueue>();
            Achqueue = new HashSet<Achqueue>();
            AttorneyLoan = new HashSet<AttorneyLoan>();
            BusinessLoan = new HashSet<BusinessLoan>();
            CourtesyPayout = new HashSet<CourtesyPayout>();
            Ddi = new HashSet<Ddi>();
            DdisendQueue = new HashSet<DdisendQueue>();
            DepositBagDetail = new HashSet<DepositBagDetail>();
            DepositChkDetail = new HashSet<DepositChkDetail>();
            DocumentSigningStatus = new HashSet<DocumentSigningStatus>();
            DocuwareLoanLkup = new HashSet<DocuwareLoanLkup>();
            ErrorLog = new HashSet<ErrorLog>();
            ExcludeFromCapsHistory = new HashSet<ExcludeFromCapsHistory>();
            FormLetterOnDemand = new HashSet<FormLetterOnDemand>();
            FormLetterPrinted = new HashSet<FormLetterPrinted>();
            InsuranceClaim = new HashSet<InsuranceClaim>();
            InsurancePayment = new HashSet<InsurancePayment>();
            LoanApplication = new HashSet<LoanApplication>();
            LoanCcallChange = new HashSet<LoanCcallChange>();
            LoanCheck = new HashSet<LoanCheck>();
            LoanDocPrinted = new HashSet<LoanDocPrinted>();
            LoanFunding = new HashSet<LoanFunding>();
            LoanFundingMethodHistory = new HashSet<LoanFundingMethodHistory>();
            LoanIncome = new HashSet<LoanIncome>();
            LoanNote = new HashSet<LoanNote>();
            LoanOverride = new HashSet<LoanOverride>();
            LoanPayment = new HashSet<LoanPayment>();
            LoanService = new HashSet<LoanService>();
            LoanWebReviewTemplateXref = new HashSet<LoanWebReviewTemplateXref>();
            MpayAmort = new HashSet<MpayAmort>();
            MpayAmortDueDateChange = new HashSet<MpayAmortDueDateChange>();
            MpayInterest = new HashSet<MpayInterest>();
            MpayLoan = new HashSet<MpayLoan>();
            OpenEndInterestRate = new HashSet<OpenEndInterestRate>();
            PaydayLoan = new HashSet<PaydayLoan>();
            PaydayLoanApproval = new HashSet<PaydayLoanApproval>();
            RbcEfundBatchDetail = new HashSet<RbcEfundBatchDetail>();
            RiagingHistory = new HashSet<RiagingHistory>();
            RiccAutoRollNewLoanKeyNavigation = new HashSet<RiccAutoRoll>();
            RiccAutoRollOrigLoanKeyNavigation = new HashSet<RiccAutoRoll>();
            RolloverRequest = new HashSet<RolloverRequest>();
            SignatureLoanApproval = new HashSet<SignatureLoanApproval>();
            Smsinbound = new HashSet<Smsinbound>();
            Smsoutbound = new HashSet<Smsoutbound>();
            SpayInterest = new HashSet<SpayInterest>();
            SpaySchedRollover = new HashSet<SpaySchedRollover>();
            VaultMgrAuthorizationDetail = new HashSet<VaultMgrAuthorizationDetail>();
            VehicleHistory = new HashSet<VehicleHistory>();
            VisitorEmail = new HashSet<VisitorEmail>();
            WebBlobLoanXref = new HashSet<WebBlobLoanXref>();
            WebCallQueue = new HashSet<WebCallQueue>();
            WebCallWorkQueue = new HashSet<WebCallWorkQueue>();
            WebErrorLog = new HashSet<WebErrorLog>();
            WebLead = new HashSet<WebLead>();
        }

        public int LoanKey { get; set; }
        public int TransDetailKey { get; set; }
        public int CustomerKey { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public bool CourtesyCall { get; set; }
        public int? IssuerKey { get; set; }
        public string CheckNo { get; set; }
        public bool DirectDeposit { get; set; }
        public string LoanType { get; set; }
        public string OrigCode { get; set; }
        public int? OrigLoanKey { get; set; }
        public int? PaidLoanKey { get; set; }
        public int? PaymentPlanKey { get; set; }
        public short RolloverNum { get; set; }
        public string LoanStatus { get; set; }
        public decimal LoanBalance { get; set; }
        public decimal LoanAmt { get; set; }
        public decimal CashAmt { get; set; }
        public decimal PrincAmt { get; set; }
        public decimal RatePct { get; set; }
        public decimal DiscAmt { get; set; }
        public decimal RebateAmt { get; set; }
        public decimal GraceAmt { get; set; }
        public decimal FeeAmt { get; set; }
        public decimal TransFeeAmt { get; set; }
        public decimal LienFeeAmt { get; set; }
        public bool ChargeTransFee { get; set; }
        public bool ChargeLienFee { get; set; }
        public decimal TotFeeAmt { get; set; }
        public DateTime OrigDueDate { get; set; }
        public DateTime AdjustedDueDate { get; set; }
        public bool Defaulted { get; set; }
        public DateTime? DefaultDate { get; set; }
        public bool Reversed { get; set; }
        public DateTime? ReversedDate { get; set; }
        public decimal? OrigApr { get; set; }
        public int? DrawerzKey { get; set; }
        public DateTime LoanStatusDate { get; set; }
        public bool JointLoan { get; set; }
        public string PrintLanguage { get; set; }
        public DateTime CalcDueDate { get; set; }
        public int? Dwdocid { get; set; }
        public bool Doclost { get; set; }
        public string DwLoanNo { get; set; }
        public string ProductType { get; set; }
        public string DisplayCheckNo { get; set; }
        public decimal PendingSchedAchAmt { get; set; }
        public DateTime? PendingSchedAchSent { get; set; }
        public decimal PendingCollAchAmt { get; set; }
        public DateTime? PendingCollAchSent { get; set; }
        public byte? DepositOrder { get; set; }
        public byte? DepositStatus { get; set; }
        public DateTime LoanDate { get; set; }
        public byte FundingMethod { get; set; }
        public int? CreditCardKey { get; set; }
        public bool? IsMultiCheck { get; set; }
        public int? LoanProductKey { get; set; }
        public bool? IsGailLoan { get; set; }
        public bool ExcludeFromCap { get; set; }
        public bool IsEsign { get; set; }
        public DateTime? CapsChangeDate { get; set; }
        public decimal FasterPaymentsFee { get; set; }
        public byte EsignDocMethod { get; set; }
        public decimal StandardRatePct { get; set; }
        public byte LoanRateSource { get; set; }
        public short? CreditedLocation { get; set; }
        public decimal TilaApr { get; set; }
        public decimal TilaFinanceCharge { get; set; }
        public decimal TilaAmountFinanced { get; set; }
        public decimal TilaTotalPayments { get; set; }
        public bool InterestAndFeesCapReached { get; set; }
        public DateTime? InterestAndFeesCapReachedDate { get; set; }
        public DateTime? WithdrawDate { get; set; }
        public DateTime? WithdrawAdjustedDueDate { get; set; }
        public int LoanProductConfigKey { get; set; }
        public int LoanProductTilaKey { get; set; }
        public decimal PendingPmtAmt { get; set; }
        public DateTime? PendingPmtDate { get; set; }
        public decimal PendingPmtPrinc { get; set; }
        public decimal PendingPmtInterestCap { get; set; }
        public decimal PendingPmtCabInterestCap { get; set; }
        public decimal PendingPmtFees { get; set; }
        public decimal InsuranceFeeAmt { get; set; }
        public int? CancelInsuranceTransDetailKey { get; set; }
        public bool ExcludeFromCapAch { get; set; }

        public virtual ICollection<AchprocessingQueue> AchprocessingQueue { get; set; }
        public virtual ICollection<Achqueue> Achqueue { get; set; }
        public virtual ICollection<AttorneyLoan> AttorneyLoan { get; set; }
        public virtual ICollection<BusinessLoan> BusinessLoan { get; set; }
        public virtual CheckAgain CheckAgain { get; set; }
        public virtual ICollection<CourtesyPayout> CourtesyPayout { get; set; }
        public virtual ICollection<Ddi> Ddi { get; set; }
        public virtual ICollection<DdisendQueue> DdisendQueue { get; set; }
        public virtual ICollection<DepositBagDetail> DepositBagDetail { get; set; }
        public virtual ICollection<DepositChkDetail> DepositChkDetail { get; set; }
        public virtual ICollection<DocumentSigningStatus> DocumentSigningStatus { get; set; }
        public virtual ICollection<DocuwareLoanLkup> DocuwareLoanLkup { get; set; }
        public virtual ICollection<ErrorLog> ErrorLog { get; set; }
        public virtual ICollection<ExcludeFromCapsHistory> ExcludeFromCapsHistory { get; set; }
        public virtual ICollection<FormLetterOnDemand> FormLetterOnDemand { get; set; }
        public virtual ICollection<FormLetterPrinted> FormLetterPrinted { get; set; }
        public virtual ICollection<InsuranceClaim> InsuranceClaim { get; set; }
        public virtual ICollection<InsurancePayment> InsurancePayment { get; set; }
        public virtual ICollection<LoanApplication> LoanApplication { get; set; }
        public virtual ICollection<LoanCcallChange> LoanCcallChange { get; set; }
        public virtual ICollection<LoanCheck> LoanCheck { get; set; }
        public virtual ICollection<LoanDocPrinted> LoanDocPrinted { get; set; }
        public virtual ICollection<LoanFunding> LoanFunding { get; set; }
        public virtual ICollection<LoanFundingMethodHistory> LoanFundingMethodHistory { get; set; }
        public virtual ICollection<LoanIncome> LoanIncome { get; set; }
        public virtual ICollection<LoanNote> LoanNote { get; set; }
        public virtual ICollection<LoanOverride> LoanOverride { get; set; }
        public virtual ICollection<LoanPayment> LoanPayment { get; set; }
        public virtual ICollection<LoanService> LoanService { get; set; }
        public virtual ICollection<LoanWebReviewTemplateXref> LoanWebReviewTemplateXref { get; set; }
        public virtual ICollection<MpayAmort> MpayAmort { get; set; }
        public virtual ICollection<MpayAmortDueDateChange> MpayAmortDueDateChange { get; set; }
        public virtual ICollection<MpayInterest> MpayInterest { get; set; }
        public virtual ICollection<MpayLoan> MpayLoan { get; set; }
        public virtual ICollection<OpenEndInterestRate> OpenEndInterestRate { get; set; }
        public virtual ICollection<PaydayLoan> PaydayLoan { get; set; }
        public virtual ICollection<PaydayLoanApproval> PaydayLoanApproval { get; set; }
        public virtual ICollection<RbcEfundBatchDetail> RbcEfundBatchDetail { get; set; }
        public virtual RbcEfundSecurity RbcEfundSecurity { get; set; }
        public virtual ICollection<RiagingHistory> RiagingHistory { get; set; }
        public virtual ICollection<RiccAutoRoll> RiccAutoRollNewLoanKeyNavigation { get; set; }
        public virtual ICollection<RiccAutoRoll> RiccAutoRollOrigLoanKeyNavigation { get; set; }
        public virtual ICollection<RolloverRequest> RolloverRequest { get; set; }
        public virtual ICollection<SignatureLoanApproval> SignatureLoanApproval { get; set; }
        public virtual ICollection<Smsinbound> Smsinbound { get; set; }
        public virtual ICollection<Smsoutbound> Smsoutbound { get; set; }
        public virtual ICollection<SpayInterest> SpayInterest { get; set; }
        public virtual SpayLoan SpayLoan { get; set; }
        public virtual ICollection<SpaySchedRollover> SpaySchedRollover { get; set; }
        public virtual ICollection<VaultMgrAuthorizationDetail> VaultMgrAuthorizationDetail { get; set; }
        public virtual ICollection<VehicleHistory> VehicleHistory { get; set; }
        public virtual ICollection<VisitorEmail> VisitorEmail { get; set; }
        public virtual ICollection<WebBlobLoanXref> WebBlobLoanXref { get; set; }
        public virtual ICollection<WebCallQueue> WebCallQueue { get; set; }
        public virtual ICollection<WebCallWorkQueue> WebCallWorkQueue { get; set; }
        public virtual ICollection<WebErrorLog> WebErrorLog { get; set; }
        public virtual ICollection<WebLead> WebLead { get; set; }
        public virtual WebLoanCreditFraud WebLoanCreditFraud { get; set; }
        public virtual CreditCards CreditCardKeyNavigation { get; set; }
        public virtual Company CreditedLocationNavigation { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
        public virtual TransDetail TransDetailKeyNavigation { get; set; }
    }
}
