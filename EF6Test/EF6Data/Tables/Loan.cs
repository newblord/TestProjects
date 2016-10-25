namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Loan")]
    public partial class Loan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Loan()
        {
            ACHProcessingQueues = new HashSet<ACHProcessingQueue>();
            ACHQueues = new HashSet<ACHQueue>();
            AttorneyLoans = new HashSet<AttorneyLoan>();
            BusinessLoans = new HashSet<BusinessLoan>();
            CheckAgains = new HashSet<CheckAgain>();
            CourtesyPayouts = new HashSet<CourtesyPayout>();
            DDIs = new HashSet<DDI>();
            DDISendQueues = new HashSet<DDISendQueue>();
            DepositBagDetails = new HashSet<DepositBagDetail>();
            DepositChkDetails = new HashSet<DepositChkDetail>();
            DocumentSigningStatus = new HashSet<DocumentSigningStatu>();
            DocuwareLoanLkups = new HashSet<DocuwareLoanLkup>();
            ErrorLogs = new HashSet<ErrorLog>();
            ExcludeFromCapsHistories = new HashSet<ExcludeFromCapsHistory>();
            FormLetterOnDemands = new HashSet<FormLetterOnDemand>();
            FormLetterPrinteds = new HashSet<FormLetterPrinted>();
            InsuranceClaims = new HashSet<InsuranceClaim>();
            InsurancePayments = new HashSet<InsurancePayment>();
            LoanApplications = new HashSet<LoanApplication>();
            LoanCCallChanges = new HashSet<LoanCCallChange>();
            LoanChecks = new HashSet<LoanCheck>();
            LoanDocPrinteds = new HashSet<LoanDocPrinted>();
            LoanFundings = new HashSet<LoanFunding>();
            LoanFundingMethodHistories = new HashSet<LoanFundingMethodHistory>();
            LoanIncomes = new HashSet<LoanIncome>();
            LoanNotes = new HashSet<LoanNote>();
            LoanOverrides = new HashSet<LoanOverride>();
            LoanPayments = new HashSet<LoanPayment>();
            LoanServices = new HashSet<LoanService>();
            LoanWebReviewTemplateXrefs = new HashSet<LoanWebReviewTemplateXref>();
            MPayLoans = new HashSet<MPayLoan>();
            MPayAmorts = new HashSet<MPayAmort>();
            MPayAmortDueDateChanges = new HashSet<MPayAmortDueDateChange>();
            MPayInterests = new HashSet<MPayInterest>();
            OpenEndInterestRates = new HashSet<OpenEndInterestRate>();
            PaydayLoans = new HashSet<PaydayLoan>();
            PaydayLoanApprovals = new HashSet<PaydayLoanApproval>();
            RbcEFundBatchDetails = new HashSet<RbcEFundBatchDetail>();
            RbcEFundSecurities = new HashSet<RbcEFundSecurity>();
            RIAgingHistories = new HashSet<RIAgingHistory>();
            RiccAutoRolls = new HashSet<RiccAutoRoll>();
            RiccAutoRolls1 = new HashSet<RiccAutoRoll>();
            RolloverRequests = new HashSet<RolloverRequest>();
            SignatureLoanApprovals = new HashSet<SignatureLoanApproval>();
            SMSInbounds = new HashSet<SMSInbound>();
            SMSOutbounds = new HashSet<SMSOutbound>();
            SPayInterests = new HashSet<SPayInterest>();
            SPayLoans = new HashSet<SPayLoan>();
            SPaySchedRollovers = new HashSet<SPaySchedRollover>();
            VaultMgrAuthorizationDetails = new HashSet<VaultMgrAuthorizationDetail>();
            VehicleHistories = new HashSet<VehicleHistory>();
            VisitorEmails = new HashSet<VisitorEmail>();
            WebBlobLoanXrefs = new HashSet<WebBlobLoanXref>();
            WebCallQueues = new HashSet<WebCallQueue>();
            WebCallWorkQueues = new HashSet<WebCallWorkQueue>();
            WebErrorLogs = new HashSet<WebErrorLog>();
            WebLeads = new HashSet<WebLead>();
            WebLoanCreditFrauds = new HashSet<WebLoanCreditFraud>();
        }

        [Key]
        public int LOAN_KEY { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public bool COURTESY_CALL { get; set; }

        public int? ISSUER_KEY { get; set; }

        [Required]
        [StringLength(10)]
        public string CHECK_NO { get; set; }

        public bool DIRECT_DEPOSIT { get; set; }

        [Required]
        [StringLength(1)]
        public string LOAN_TYPE { get; set; }

        [Required]
        [StringLength(1)]
        public string ORIG_CODE { get; set; }

        public int? ORIG_LOAN_KEY { get; set; }

        public int? PAID_LOAN_KEY { get; set; }

        public int? PAYMENT_PLAN_KEY { get; set; }

        public short ROLLOVER_NUM { get; set; }

        [Required]
        [StringLength(1)]
        public string LOAN_STATUS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CASH_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINC_AMT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RATE_PCT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal DISC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal REBATE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal GRACE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LIEN_FEE_AMT { get; set; }

        public bool CHARGE_TRANS_FEE { get; set; }

        public bool CHARGE_LIEN_FEE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOT_FEE_AMT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ORIG_DUE_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ADJUSTED_DUE_DATE { get; set; }

        public bool DEFAULTED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DEFAULT_DATE { get; set; }

        public bool REVERSED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? REVERSED_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ORIG_APR { get; set; }

        public int? DRAWERZ_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime LOAN_STATUS_DATE { get; set; }

        public bool JOINT_LOAN { get; set; }

        [Required]
        [StringLength(1)]
        public string PRINT_LANGUAGE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CALC_DUE_DATE { get; set; }

        public int? DWDOCID { get; set; }

        public bool DOCLOST { get; set; }

        [Required]
        [StringLength(15)]
        public string DW_LOAN_NO { get; set; }

        [Required]
        [StringLength(1)]
        public string PRODUCT_TYPE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        [StringLength(10)]
        public string DISPLAY_CHECK_NO { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PENDING_SCHED_ACH_AMT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PENDING_SCHED_ACH_SENT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PENDING_COLL_ACH_AMT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PENDING_COLL_ACH_SENT { get; set; }

        public byte? DEPOSIT_ORDER { get; set; }

        public byte? DEPOSIT_STATUS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime LOAN_DATE { get; set; }

        public byte FUNDING_METHOD { get; set; }

        public int? CREDIT_CARD_KEY { get; set; }

        public bool? IS_MULTI_CHECK { get; set; }

        public int? LOAN_PRODUCT_KEY { get; set; }

        public bool? IS_GAIL_LOAN { get; set; }

        public bool EXCLUDE_FROM_CAP { get; set; }

        public bool IS_ESIGN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CAPS_CHANGE_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal FASTER_PAYMENTS_FEE { get; set; }

        public byte ESIGN_DOC_METHOD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal STANDARD_RATE_PCT { get; set; }

        public byte LOAN_RATE_SOURCE { get; set; }

        public short? CREDITED_LOCATION { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TILA_APR { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TILA_FINANCE_CHARGE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TILA_AMOUNT_FINANCED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TILA_TOTAL_PAYMENTS { get; set; }

        public bool INTEREST_AND_FEES_CAP_REACHED { get; set; }

        [Column(TypeName = "date")]
        public DateTime? INTEREST_AND_FEES_CAP_REACHED_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? WITHDRAW_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? WITHDRAW_ADJUSTED_DUE_DATE { get; set; }

        public int LOAN_PRODUCT_CONFIG_KEY { get; set; }

        public int LOAN_PRODUCT_TILA_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PENDING_PMT_AMT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PENDING_PMT_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PENDING_PMT_PRINC { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PENDING_PMT_INTEREST_CAP { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PENDING_PMT_CAB_INTEREST_CAP { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PENDING_PMT_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INSURANCE_FEE_AMT { get; set; }

        public int? CANCEL_INSURANCE_TRANS_DETAIL_KEY { get; set; }

        public bool EXCLUDE_FROM_CAP_ACH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACHProcessingQueue> ACHProcessingQueues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACHQueue> ACHQueues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttorneyLoan> AttorneyLoans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessLoan> BusinessLoans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckAgain> CheckAgains { get; set; }

        public virtual Company Company { get; set; }

        public virtual Company Company1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourtesyPayout> CourtesyPayouts { get; set; }

        public virtual CreditCard CreditCard { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DDI> DDIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DDISendQueue> DDISendQueues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepositBagDetail> DepositBagDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepositChkDetail> DepositChkDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentSigningStatu> DocumentSigningStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocuwareLoanLkup> DocuwareLoanLkups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ErrorLog> ErrorLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExcludeFromCapsHistory> ExcludeFromCapsHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetterOnDemand> FormLetterOnDemands { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetterPrinted> FormLetterPrinteds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InsuranceClaim> InsuranceClaims { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InsurancePayment> InsurancePayments { get; set; }

        public virtual TransDetail TransDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplication> LoanApplications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanCCallChange> LoanCCallChanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanCheck> LoanChecks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanDocPrinted> LoanDocPrinteds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanFunding> LoanFundings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanFundingMethodHistory> LoanFundingMethodHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanIncome> LoanIncomes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanNote> LoanNotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanOverride> LoanOverrides { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanPayment> LoanPayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanService> LoanServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanWebReviewTemplateXref> LoanWebReviewTemplateXrefs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MPayLoan> MPayLoans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MPayAmort> MPayAmorts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MPayAmortDueDateChange> MPayAmortDueDateChanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MPayInterest> MPayInterests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpenEndInterestRate> OpenEndInterestRates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaydayLoan> PaydayLoans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaydayLoanApproval> PaydayLoanApprovals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RbcEFundBatchDetail> RbcEFundBatchDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RbcEFundSecurity> RbcEFundSecurities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RIAgingHistory> RIAgingHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RiccAutoRoll> RiccAutoRolls { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RiccAutoRoll> RiccAutoRolls1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolloverRequest> RolloverRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SignatureLoanApproval> SignatureLoanApprovals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SMSInbound> SMSInbounds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SMSOutbound> SMSOutbounds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SPayInterest> SPayInterests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SPayLoan> SPayLoans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SPaySchedRollover> SPaySchedRollovers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaultMgrAuthorizationDetail> VaultMgrAuthorizationDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleHistory> VehicleHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitorEmail> VisitorEmails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebBlobLoanXref> WebBlobLoanXrefs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallQueue> WebCallQueues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallWorkQueue> WebCallWorkQueues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebErrorLog> WebErrorLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebLead> WebLeads { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebLoanCreditFraud> WebLoanCreditFrauds { get; set; }
    }
}
