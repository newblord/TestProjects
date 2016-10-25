namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            ACH_History = new HashSet<ACH_History>();
            ACH_HistoryCashedCheck = new HashSet<ACH_HistoryCashedCheck>();
            ACHPendings = new HashSet<ACHPending>();
            AMLForeignAddresses = new HashSet<AMLForeignAddress>();
            BlockMailings = new HashSet<BlockMailing>();
            CashedChecks = new HashSet<CashedCheck>();
            CashMoneyToCuroXRefs = new HashSet<CashMoneyToCuroXRef>();
            CCardResponses = new HashSet<CCardResponse>();
            CCardResponses1 = new HashSet<CCardRespons>();
            CollectionNotes = new HashSet<CollectionNote>();
            CourtesyPayouts = new HashSet<CourtesyPayout>();
            CpiuDetails = new HashSet<CpiuDetail>();
            CreditCards = new HashSet<CreditCard>();
            CreditCardTrans = new HashSet<CreditCardTran>();
            CreditCardXRefs = new HashSet<CreditCardXRef>();
            CustomerActivities = new HashSet<CustomerActivity>();
            CustomerAddresses = new HashSet<CustomerAddress>();
            CustomerBusinesses = new HashSet<CustomerBusiness>();
            CustomerCreditRpts = new HashSet<CustomerCreditRpt>();
            CustomerDocuments = new HashSet<CustomerDocument>();
            CustomerEarnedCredits = new HashSet<CustomerEarnedCredit>();
            CustomerEdits = new HashSet<CustomerEdit>();
            CustomerEmployers = new HashSet<CustomerEmployer>();
            CustomerExpenses = new HashSet<CustomerExpense>();
            CustomerFeedbacks = new HashSet<CustomerFeedback>();
            CustomerFlashResponses = new HashSet<CustomerFlashResponse>();
            CustomerIdentifications = new HashSet<CustomerIdentification>();
            CustomerIncomes = new HashSet<CustomerIncome>();
            CustomerLastCreditReports = new HashSet<CustomerLastCreditReport>();
            CustomerNotes = new HashSet<CustomerNote>();
            CustomerPhoneNumbers = new HashSet<CustomerPhoneNumber>();
            DepositBagDetails = new HashSet<DepositBagDetail>();
            DepositChkDetails = new HashSet<DepositChkDetail>();
            Doc10000Trans = new HashSet<Doc10000Trans>();
            ErrorLogs = new HashSet<ErrorLog>();
            ExperianCardValidations = new HashSet<ExperianCardValidation>();
            FormLetterPrinteds = new HashSet<FormLetterPrinted>();
            FormLetterResults = new HashSet<FormLetterResult>();
            FurtherFinanceResults = new HashSet<FurtherFinanceResult>();
            GoldTransCustomers = new HashSet<GoldTransCustomer>();
            GoodCustomerStudies = new HashSet<GoodCustomerStudy>();
            Issuers = new HashSet<Issuer>();
            Loans = new HashSet<Loan>();
            LoanApplications = new HashSet<LoanApplication>();
            LoanApplicationVehicleInformations = new HashSet<LoanApplicationVehicleInformation>();
            LoanDueDateChanges = new HashSet<LoanDueDateChange>();
            LoanNotes = new HashSet<LoanNote>();
            MetroIIBaseSegments = new HashSet<MetroIIBaseSegment>();
            OptPlusDirectDeposits = new HashSet<OptPlusDirectDeposit>();
            OptPlusEdits = new HashSet<OptPlusEdit>();
            OptPlusEmployments = new HashSet<OptPlusEmployment>();
            OptPlusRDFAccountCards = new HashSet<OptPlusRDFAccountCard>();
            OptPlusRDFAuthorizedTransactions = new HashSet<OptPlusRDFAuthorizedTransaction>();
            OptPlusRDFCustomerMasters = new HashSet<OptPlusRDFCustomerMaster>();
            OptPlusRDFODTransitions = new HashSet<OptPlusRDFODTransition>();
            OptPlusRDFPostedTrans = new HashSet<OptPlusRDFPostedTran>();
            PaydayLoanQualifications = new HashSet<PaydayLoanQualification>();
            PrepaidCardTrans = new HashSet<PrepaidCardTran>();
            PrepaidFISAccountBalances = new HashSet<PrepaidFISAccountBalance>();
            PrepaidFISAuthTrans = new HashSet<PrepaidFISAuthTran>();
            PrepaidFISCustomerMasters = new HashSet<PrepaidFISCustomerMaster>();
            PrepaidFISPostedTrans = new HashSet<PrepaidFISPostedTran>();
            PromiseToPays = new HashSet<PromiseToPay>();
            RbcEFundBatchDetails = new HashSet<RbcEFundBatchDetail>();
            RIAgingHistories = new HashSet<RIAgingHistory>();
            RISREPTs = new HashSet<RISREPT>();
            ServiceTrans = new HashSet<ServiceTran>();
            SkipTraceThreads = new HashSet<SkipTraceThread>();
            SPaySchedRollovers = new HashSet<SPaySchedRollover>();
            TitleLoans = new HashSet<TitleLoan>();
            TransPOS = new HashSet<TransPOS>();
            VaultMgrAuthorizationDetails = new HashSet<VaultMgrAuthorizationDetail>();
            VehicleHistories = new HashSet<VehicleHistory>();
            WebCallQueues = new HashSet<WebCallQueue>();
            WebCallWorkQueues = new HashSet<WebCallWorkQueue>();
            WebErrorLogs = new HashSet<WebErrorLog>();
            WebLeads = new HashSet<WebLead>();
            WebLoanCreditFrauds = new HashSet<WebLoanCreditFraud>();
        }

        [Key]
        public int CUSTOMER_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public short? TLOC { get; set; }

        [StringLength(3)]
        public string TUPT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? TUPD { get; set; }

        [StringLength(9)]
        public string SSN { get; set; }

        [StringLength(12)]
        public string ID_NO { get; set; }

        [StringLength(24)]
        public string FIRSTNAME { get; set; }

        [StringLength(10)]
        public string MIDNAME { get; set; }

        [StringLength(25)]
        public string LASTNAME { get; set; }

        [Required]
        [StringLength(10)]
        public string HOME_ADDR_NUM { get; set; }

        [Required]
        [StringLength(2)]
        public string HOME_ADDR_PRE_DIR { get; set; }

        [Required]
        [StringLength(40)]
        public string HOME_ADDR_STREET { get; set; }

        [Required]
        [StringLength(10)]
        public string HOME_ADDR_SUFFIX { get; set; }

        [Required]
        [StringLength(10)]
        public string HOME_ADDR_SUITE { get; set; }

        [Required]
        [StringLength(15)]
        public string HOME_ADDR_SUITE_NUM { get; set; }

        [StringLength(25)]
        public string COUNTY { get; set; }

        [Required]
        [StringLength(12)]
        public string HOME_PHONE { get; set; }

        [Required]
        [StringLength(12)]
        public string CELL_PHONE { get; set; }

        [Required]
        [StringLength(12)]
        public string WORK_PHONE { get; set; }

        [StringLength(10)]
        public string WORK_PHONE_EXT { get; set; }

        [StringLength(50)]
        public string SPOUSE_FIRSTNAME { get; set; }

        [StringLength(10)]
        public string SPOUSE_MIDNAME { get; set; }

        [StringLength(50)]
        public string SPOUSE_LASTNAME { get; set; }

        [StringLength(9)]
        public string SPOUSE_SSN { get; set; }

        [StringLength(50)]
        public string SPOUSE_WORK_NAME { get; set; }

        [StringLength(12)]
        public string SPOUSE_WORK_PHONE { get; set; }

        [StringLength(10)]
        public string SPOUSE_WORK_PHONE_EXT { get; set; }

        public bool? SPOUSE_DIR_DEP { get; set; }

        [StringLength(1)]
        public string SPOUSE_PAYCYCLE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOB { get; set; }

        [StringLength(1)]
        public string GENDER { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CKLIMIT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRALIMIT { get; set; }

        [StringLength(50)]
        public string UTIL1 { get; set; }

        [StringLength(50)]
        public string UTIL2 { get; set; }

        [StringLength(50)]
        public string UTIL3 { get; set; }

        public bool? BOUNCED { get; set; }

        [StringLength(1)]
        public string HOW_REF_OBSOLETE { get; set; }

        [StringLength(50)]
        public string EMAIL_OBSOLETE { get; set; }

        [StringLength(50)]
        public string REF1_FIRSTNAME { get; set; }

        [StringLength(50)]
        public string REF1_LASTNAME { get; set; }

        [Required]
        [StringLength(12)]
        public string REF1_PHONE { get; set; }

        [StringLength(1)]
        public string REF1_RELATIONSHIP { get; set; }

        [StringLength(50)]
        public string REF2_FIRSTNAME { get; set; }

        [StringLength(50)]
        public string REF2_LASTNAME { get; set; }

        [Required]
        [StringLength(12)]
        public string REF2_PHONE { get; set; }

        [StringLength(1)]
        public string REF2_RELATIONSHIP { get; set; }

        public bool? NEW_CUST_REF { get; set; }

        public int? NEW_CUST_REF_ID { get; set; }

        [Required]
        [StringLength(1)]
        public string PAY_CYCLE { get; set; }

        public byte PAY_CYCLE_DAY { get; set; }

        public byte PAY_CYCLE_1ST { get; set; }

        public byte PAY_CYCLE_2ND { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BIWEEK_BASE { get; set; }

        [Required]
        [StringLength(1)]
        public string PAY_CYCLE_MONTH_INT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CALC_PAY_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PAY_CYCLE_UPDATED { get; set; }

        [StringLength(3)]
        public string PAY_CYCLE_UPDATED_BY { get; set; }

        [StringLength(1)]
        public string ACH_STATUS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal RI_BALANCE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RI_FOLLOWUP { get; set; }

        public int CreditScore { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LastScoreDate { get; set; }

        public byte OwnRentOther { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ResidenceSince { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LAST_APP_DATE { get; set; }

        [StringLength(10)]
        public string LEGAL_NUMBER { get; set; }

        public bool ACCT_BLOCKED { get; set; }

        [Required]
        [StringLength(1)]
        public string COURTESY_CALL_NUM { get; set; }

        public int? LAST_ACH_RESULT { get; set; }

        public bool ACTIVE_MILITARY { get; set; }

        [StringLength(15)]
        public string CUST_ID_SOURCE { get; set; }

        public bool? MILITARY_MEMBER { get; set; }

        public bool? MIL_ACTIVE_DUTY { get; set; }

        public bool? MIL_COMBAT_DUTY { get; set; }

        public bool? MIL_RESERVE_NOT_ACTIVE { get; set; }

        public bool? MIL_RESERVE_ACTIVE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CHK_CASHING_FEE_NOTICE_DATE { get; set; }

        public short? CHK_CASHING_FEE_NOTICE_LOCATION { get; set; }

        [StringLength(12)]
        public string SPOUSE_HOME_PHONE { get; set; }

        [StringLength(12)]
        public string SPOUSE_CELL_PHONE { get; set; }

        public bool? INET_APPROVED { get; set; }

        public bool CC_BLOCK { get; set; }

        public byte? ACCT_BLOCKED_CODE { get; set; }

        [Required]
        [StringLength(2)]
        public string HOME_ADDR_POST_DIR { get; set; }

        public short REFERRAL_METHOD_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime EMAIL_VERIFY_DATE { get; set; }

        public byte EMAIL_LAST_RESPONSE { get; set; }

        [StringLength(38)]
        public string ORIGINAL_WEB_VISIT_SOURCE { get; set; }

        [Required]
        [StringLength(3)]
        public string HOME_COUNTRY { get; set; }

        [StringLength(15)]
        public string NIN { get; set; }

        public int? OPTPLUS_CARRIER_KEY { get; set; }

        [StringLength(12)]
        public string ORIGINAL_PRN { get; set; }

        [StringLength(30)]
        public string OPTPLUS_ACCOUNT_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string HOME_CITY { get; set; }

        [Required]
        [StringLength(2)]
        public string HOME_STATE { get; set; }

        [Required]
        [StringLength(10)]
        public string HOME_ZIPCODE { get; set; }

        [Required]
        [StringLength(25)]
        public string HOME_COUNTY { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        [StringLength(30)]
        public string CITY { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        [StringLength(2)]
        public string STATE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        [StringLength(10)]
        public string ZIPCODE { get; set; }

        [Required]
        [StringLength(3)]
        public string ADDRESS_FORMAT { get; set; }

        [Required]
        [StringLength(50)]
        public string HOME_FLAT_NUM { get; set; }

        [Required]
        [StringLength(10)]
        public string HOME_BUILDING_NUM { get; set; }

        [Required]
        [StringLength(40)]
        public string HOME_BUILDING_NAME { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string HOME_ADDRESS_LINE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string HOME_ADDRESS_CSZ { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(150)]
        public string HOME_ADDRESS_LINE_3 { get; set; }

        public bool? OPTPLUS_CIP_DENIAL { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string HOME_ADDRESS_LINE_1 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(150)]
        public string HOME_ADDRESS_LINE_2 { get; set; }

        public bool PAY_CYCLE_COUNT_DAYS_FROM_END_OF_MONTH { get; set; }

        public bool MISMATCHED_DUECYCLE_APPROVED { get; set; }

        public byte ADJUST_DUE_DATE_FOR_HOLIDAYS_AND_WEEKENDS_METHOD { get; set; }

        public int TITLE { get; set; }

        [StringLength(24)]
        public string NICKNAME { get; set; }

        public int VISITOR_KEY { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int PAY_INFO_COMPLETE { get; set; }

        [Required]
        [StringLength(1)]
        public string PREFERRED_LANGUAGE { get; set; }

        public bool IS_IN_CHAIN { get; set; }

        public short? DEPENDENTS { get; set; }

        public byte MARITAL_STATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACH_History> ACH_History { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACH_HistoryCashedCheck> ACH_HistoryCashedCheck { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACHPending> ACHPendings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AMLForeignAddress> AMLForeignAddresses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlockMailing> BlockMailings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CashedCheck> CashedChecks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CashMoneyToCuroXRef> CashMoneyToCuroXRefs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CCardResponse> CCardResponses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CCardRespons> CCardResponses1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CollectionNote> CollectionNotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourtesyPayout> CourtesyPayouts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CpiuDetail> CpiuDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CreditCard> CreditCards { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CreditCardTran> CreditCardTrans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CreditCardXRef> CreditCardXRefs { get; set; }

        public virtual OptPlusCarrier OptPlusCarrier { get; set; }

        public virtual WebVisitSource WebVisitSource { get; set; }

        public virtual PersonTitle PersonTitle { get; set; }

        public virtual ReferralMethod ReferralMethod { get; set; }

        public virtual US_States US_States { get; set; }

        public virtual Visitor Visitor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerActivity> CustomerActivities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerBusiness> CustomerBusinesses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerCreditRpt> CustomerCreditRpts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerDocument> CustomerDocuments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerEarnedCredit> CustomerEarnedCredits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerEdit> CustomerEdits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerEmployer> CustomerEmployers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerExpense> CustomerExpenses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerFeedback> CustomerFeedbacks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerFlashResponse> CustomerFlashResponses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerIdentification> CustomerIdentifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerIncome> CustomerIncomes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerLastCreditReport> CustomerLastCreditReports { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerNote> CustomerNotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerPhoneNumber> CustomerPhoneNumbers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepositBagDetail> DepositBagDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepositChkDetail> DepositChkDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doc10000Trans> Doc10000Trans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ErrorLog> ErrorLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExperianCardValidation> ExperianCardValidations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetterPrinted> FormLetterPrinteds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetterResult> FormLetterResults { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FurtherFinanceResult> FurtherFinanceResults { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoldTransCustomer> GoldTransCustomers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoodCustomerStudy> GoodCustomerStudies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Issuer> Issuers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Loan> Loans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplication> LoanApplications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplicationVehicleInformation> LoanApplicationVehicleInformations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanDueDateChange> LoanDueDateChanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanNote> LoanNotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MetroIIBaseSegment> MetroIIBaseSegments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptPlusDirectDeposit> OptPlusDirectDeposits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptPlusEdit> OptPlusEdits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptPlusEmployment> OptPlusEmployments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptPlusRDFAccountCard> OptPlusRDFAccountCards { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptPlusRDFAuthorizedTransaction> OptPlusRDFAuthorizedTransactions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptPlusRDFCustomerMaster> OptPlusRDFCustomerMasters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptPlusRDFODTransition> OptPlusRDFODTransitions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptPlusRDFPostedTran> OptPlusRDFPostedTrans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaydayLoanQualification> PaydayLoanQualifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrepaidCardTran> PrepaidCardTrans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrepaidFISAccountBalance> PrepaidFISAccountBalances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrepaidFISAuthTran> PrepaidFISAuthTrans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrepaidFISCustomerMaster> PrepaidFISCustomerMasters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrepaidFISPostedTran> PrepaidFISPostedTrans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PromiseToPay> PromiseToPays { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RbcEFundBatchDetail> RbcEFundBatchDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RIAgingHistory> RIAgingHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RISREPT> RISREPTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceTran> ServiceTrans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SkipTraceThread> SkipTraceThreads { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SPaySchedRollover> SPaySchedRollovers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TitleLoan> TitleLoans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransPOS> TransPOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaultMgrAuthorizationDetail> VaultMgrAuthorizationDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleHistory> VehicleHistories { get; set; }

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
