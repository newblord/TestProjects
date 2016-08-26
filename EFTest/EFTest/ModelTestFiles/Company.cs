namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Company")]
    public partial class Company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Company()
        {
            ACH_History = new HashSet<ACH_History>();
            ACH_HistoryCashedCheck = new HashSet<ACH_HistoryCashedCheck>();
            ACH_Sent = new HashSet<ACH_Sent>();
            ACHBankConfigExceptions = new HashSet<ACHBankConfigException>();
            CashedChecks = new HashSet<CashedCheck>();
            CCardResponses = new HashSet<CCardRespons>();
            CollectionActions = new HashSet<CollectionAction>();
            CompanyDocumentResources = new HashSet<CompanyDocumentResource>();
            CompanyExpenseTypes = new HashSet<CompanyExpenseType>();
            CurrencyExchangeConfigs = new HashSet<CurrencyExchangeConfig>();
            CurrencyExchangeTrans = new HashSet<CurrencyExchangeTran>();
            CustomerDocuments = new HashSet<CustomerDocument>();
            CustomerFeedbacks = new HashSet<CustomerFeedback>();
            CustomerLeadLocations = new HashSet<CustomerLeadLocation>();
            DepositBags = new HashSet<DepositBag>();
            DepositChks = new HashSet<DepositChk>();
            DiscountLocations = new HashSet<DiscountLocation>();
            ExcludeFromCapsHistories = new HashSet<ExcludeFromCapsHistory>();
            GiftCards = new HashSet<GiftCard>();
            GoldConfigs = new HashSet<GoldConfig>();
            GoldTrans = new HashSet<GoldTran>();
            ImageCashLetterDetails = new HashSet<ImageCashLetterDetail>();
            IncomeTypeLocations = new HashSet<IncomeTypeLocation>();
            IncomeVerifyMethodLocations = new HashSet<IncomeVerifyMethodLocation>();
            Issuers = new HashSet<Issuer>();
            Issuers1 = new HashSet<Issuer>();
            Loans = new HashSet<Loan>();
            Loans1 = new HashSet<Loan>();
            LoanDueDateChanges = new HashSet<LoanDueDateChange>();
            LoanPayments = new HashSet<LoanPayment>();
            LoanProductBlockeds = new HashSet<LoanProductBlocked>();
            LoanProductConfigLoanStats = new HashSet<LoanProductConfigLoanStat>();
            LoanProductEnableNewLoans = new HashSet<LoanProductEnableNewLoan>();
            LoanProductEnableNewLoans1 = new HashSet<LoanProductEnableNewLoan>();
            LoanProductRollovers = new HashSet<LoanProductRollover>();
            LocationUS_ZipcodesXRef = new HashSet<LocationUS_ZipcodesXRef>();
            PhoneSkillsCalls = new HashSet<PhoneSkillsCall>();
            PrepaidCardBinCompanies = new HashSet<PrepaidCardBinCompany>();
            PrepaidCardTrans = new HashSet<PrepaidCardTran>();
            ProductOpenLoanMatrices = new HashSet<ProductOpenLoanMatrix>();
            RISREPTs = new HashSet<RISREPT>();
            SkipTraceStep_Location = new HashSet<SkipTraceStep_Location>();
            TitleLoans = new HashSet<TitleLoan>();
            TransferFundsInterStores = new HashSet<TransferFundsInterStore>();
            TransferFundsInterStores1 = new HashSet<TransferFundsInterStore>();
            VaultMgrAssignments = new HashSet<VaultMgrAssignment>();
            VaultMgrAuthorizations = new HashSet<VaultMgrAuthorization>();
            Vehicles = new HashSet<Vehicle>();
            WebLoanCreditFrauds = new HashSet<WebLoanCreditFraud>();
            FormLetters = new HashSet<FormLetter>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOCATION { get; set; }

        [Column("COMPANY")]
        [Required]
        [StringLength(25)]
        public string COMPANY1 { get; set; }

        [Required]
        [StringLength(12)]
        public string PHONE { get; set; }

        [StringLength(3)]
        public string AREA_CODE { get; set; }

        public short MARKET_KEY { get; set; }

        public bool IS_COLLECTIONS { get; set; }

        public bool IS_INTERNET { get; set; }

        public bool IS_AUTOPRINT_MO { get; set; }

        public bool IS_AUTOPRINT_RECEIPT { get; set; }

        public bool IS_AUTOPRINT_CTR { get; set; }

        public bool ENABLE_DIALER { get; set; }

        public bool ENABLE_VAULT_MGR { get; set; }

        public bool ENABLE_CCARD { get; set; }

        public bool ENABLE_RITA { get; set; }

        public bool ENABLE_EPP { get; set; }

        public bool ENABLE_NPA_REFERRAL { get; set; }

        [Required]
        [StringLength(6)]
        public string ACH_USERNAME { get; set; }

        [Required]
        [StringLength(15)]
        public string ACH_PASSWORD { get; set; }

        [Required]
        [StringLength(4)]
        public string ACH_AD_ASTRA_USERNAME { get; set; }

        [Required]
        [StringLength(15)]
        public string ACH_AD_ASTRA_PASSWORD { get; set; }

        [Required]
        [StringLength(8)]
        public string RITA_VNUM { get; set; }

        [Required]
        [StringLength(50)]
        public string EPP_KEY { get; set; }

        [Required]
        [StringLength(16)]
        public string MERCHANT_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string EMAIL_ADDR { get; set; }

        [Required]
        [StringLength(50)]
        public string EMAIL_SMTP { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal DEF_SURCHARGE { get; set; }

        [Required]
        [StringLength(3)]
        public string ACCTG_TELLER { get; set; }

        public short PASSWORD_EXP_DAYS { get; set; }

        public short AUTH_CUST_DAY_LIMIT { get; set; }

        public short AUTH_ISS_DAY_LIMIT { get; set; }

        public short APP_RENEWAL_DAYS { get; set; }

        public byte REQ_FIELDS_DAYS_LAST_LOAN { get; set; }

        public bool PRINT_CHK_FEE_NOTICE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CHK_FEE_LAST_UPDATE { get; set; }

        public byte RECEIPT_COPIES { get; set; }

        [StringLength(300)]
        public string RECEIPT_DUNNING_MSG { get; set; }

        [Required]
        [StringLength(3)]
        public string CURR_VAULT_MGR { get; set; }

        [Required]
        [StringLength(20)]
        public string SOLOMON_ID { get; set; }

        public bool SOLOMON_TITLE_EXISTS { get; set; }

        [Required]
        [StringLength(20)]
        public string SOLOMON_TITLE_ID { get; set; }

        public bool IS_SDN_CUSTOMER { get; set; }

        public bool IS_SDN_ISSUER { get; set; }

        [Required]
        [StringLength(500)]
        public string EMAIL_TEMPLATE_PATH { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public decimal LONGITUDE { get; set; }

        public decimal LATITUDE { get; set; }

        [Required]
        [StringLength(100)]
        public string STORE_HOURS { get; set; }

        public bool IS_SEND_EMAIL { get; set; }

        public bool ENABLE_VEREPAY { get; set; }

        [Required]
        [StringLength(10)]
        public string VEREPAY_TERMINAL_ID { get; set; }

        [Required]
        [StringLength(19)]
        public string VEREPAY_STORE_KEY { get; set; }

        public bool IS_CORPORATE { get; set; }

        public bool ENABLE_STATE_DB_REPORTING { get; set; }

        public bool SOLOMON_NONCASH_EXISTS { get; set; }

        [Required]
        [StringLength(20)]
        public string SOLOMON_NONCASH_ID { get; set; }

        [Required]
        [StringLength(3)]
        public string COUNTRY_CODE { get; set; }

        [Required]
        [StringLength(2)]
        public string BUSINESS_STATE { get; set; }

        public short? DISTRICT_KEY { get; set; }

        public byte OPTPLUS_PAYOUT_AS_CASH { get; set; }

        public bool ENABLE_OPTPLUS { get; set; }

        [Required]
        [StringLength(50)]
        public string ADDRESS1 { get; set; }

        [Required]
        [StringLength(30)]
        public string CITY { get; set; }

        [Required]
        [StringLength(2)]
        public string STATE { get; set; }

        [Required]
        [StringLength(10)]
        public string ZIPCODE { get; set; }

        [Required]
        [StringLength(25)]
        public string COUNTY { get; set; }

        [Required]
        [StringLength(3)]
        public string COUNTRY { get; set; }

        public bool ENABLE_COMMIDEA { get; set; }

        public int? COMMIDEA_OCIUS_ACCOUNT { get; set; }

        public bool ENABLE_LABOR_MODEL { get; set; }

        public bool ENABLE_ADDRESS_DR { get; set; }

        [Required]
        [StringLength(3)]
        public string ADDRESS_FORMAT { get; set; }

        [Required]
        [StringLength(40)]
        public string ADDR_STREET { get; set; }

        [Required]
        [StringLength(50)]
        public string FLAT_NUM { get; set; }

        [Required]
        [StringLength(10)]
        public string BUILDING_NUM { get; set; }

        [Required]
        [StringLength(40)]
        public string BUILDING_NAME { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string ADDRESS_LINE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string ADDRESS_CSZ { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(150)]
        public string ADDRESS_LINE_3 { get; set; }

        public short? COMMIDEA_LOCATION_OVERRIDE { get; set; }

        [Required]
        [StringLength(50)]
        public string ACH_URL { get; set; }

        public byte YEARS_GOOD_ADDRESS { get; set; }

        public byte REQD_PREVIOUS_ADDRESS_COUNT { get; set; }

        public bool ENABLE_CURRENCY_EXCHANGE { get; set; }

        [Required]
        [StringLength(3)]
        public string CR_TELLER { get; set; }

        public bool ENABLE_PICTURES { get; set; }

        public short? RETAKE_PICTURE_DAYS { get; set; }

        public int BASE_CURRENCY_KEY { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string ADDRESS_LINE_1 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(150)]
        public string ADDRESS_LINE_2 { get; set; }

        public short INCOME_VERIFICATION_DAYS { get; set; }

        public bool ENABLE_INCOME_CALCULATOR { get; set; }

        public bool VERIFICATION_DOCS_REQUIRED { get; set; }

        public int OPTPLUS_VERSION_WSCONFIG_KEY { get; set; }

        [Required]
        [StringLength(20)]
        public string HPI_USERNAME { get; set; }

        [StringLength(20)]
        public string HPI_PASSWORD { get; set; }

        public bool ENABLE_EXPERIAN_DEBIT_CARD_VERIFICATION { get; set; }

        public bool ENABLE_DCARD_PAYMENT_FEE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal DCARD_PAYMENT_FEE_AMT { get; set; }

        public bool ENABLE_EASYPAY_WAREHOUSE { get; set; }

        public decimal SALES_TAX_PERCENT { get; set; }

        public int ALTERNATE_LENDER_KEY { get; set; }

        public bool ENABLE_SELEX { get; set; }

        public byte SELEX_PAYOUT { get; set; }

        public bool ENABLE_DCARD_FRAUD_CHECK { get; set; }

        public bool ENABLE_CHECK_IMAGING { get; set; }

        public decimal GROSS_TO_NET_INCOME_PCT { get; set; }

        [Required]
        [StringLength(8)]
        public string WESTERN_UNION_BILLPAY_CONNECTORID { get; set; }

        public bool USE_MONEYGRAM_MO { get; set; }

        public bool USE_BLACKBOOK { get; set; }

        public bool STORE_IS_OPEN { get; set; }

        public int? CAB_LENDER_KEY { get; set; }

        public bool ENABLE_CAP_WITHDRAWAL { get; set; }

        public bool ENABLE_CURRENCY_EXCHANGE_RATE_CHANGE { get; set; }

        public bool ENABLE_TELLER_PWD_SELF_RESET { get; set; }

        [Required]
        [StringLength(6)]
        public string UTC_OFFSET { get; set; }

        [Required]
        [StringLength(6)]
        public string UTC_DST_OFFSET { get; set; }

        [Required]
        [StringLength(50)]
        public string TIME_ZONE { get; set; }

        public bool ENABLE_CHECK_AMT_VERIFY { get; set; }

        public bool ENABLE_ESIGN { get; set; }

        public short ACH_COOLING_OFF_PERIOD_DAYS { get; set; }

        public bool ENABLE_REQUIRES_JOB_TYPE { get; set; }

        public bool IS_AUTO_EOD { get; set; }

        public bool IS_SUNDAY_AUTO_SOD { get; set; }

        public bool ENABLE_CHECK_CASHING { get; set; }

        public bool ENABLE_MATCH_DUECYCLE { get; set; }

        public int ACH_GROUP_KEY { get; set; }

        public int BOA_CLIENT_ID { get; set; }

        public short DAYS_BEFORE_CHECK_SHRED { get; set; }

        public bool ENABLE_PRINT_CREDIT_AVAILABLE { get; set; }

        [Required]
        [StringLength(12)]
        public string REPRESENTATIVE_APR { get; set; }

        public bool ENABLE_PHONE_DEPOSITS { get; set; }

        public bool ENABLE_EPDQ { get; set; }

        public bool ENABLE_ADJUST_CUSTOMER_DUE_DATE_FOR_HOLIDAYS_AND_WEEKENDS { get; set; }

        public bool CHECK_CASHING_GOVT_ID_REQUIRED { get; set; }

        public bool ENABLE_OPTPLUS_LOAN_FUNDING { get; set; }

        public bool ENABLE_MONERIS { get; set; }

        [Required]
        [StringLength(25)]
        public string MONERIS_STORE_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string MONERIS_API_TOKEN { get; set; }

        public bool ENABLE_MOBILE_APP_MSG { get; set; }

        public bool? ENABLE_AVS_VALIDATION_DECLINES { get; set; }

        [Required]
        [StringLength(25)]
        public string STORE_NICKNAME { get; set; }

        public bool ENABLE_INTERNAL_AUDIT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? STORE_OPENED_DATE { get; set; }

        public short CURRENCY_EXCHANGE_NON_CUSTOMER_LIMIT { get; set; }

        public int? INTER_STORE_AR_ACCT { get; set; }

        public int? INTER_STORE_AP_ACCT { get; set; }

        public int? INTER_CO_NONCASH_AR_ACCT { get; set; }

        public int? INTER_CO_NONCASH_AP_ACCT { get; set; }

        public int? INTER_CO_TITLE_AR_ACCT { get; set; }

        public int? INTER_CO_TITLE_AP_ACCT { get; set; }

        public int? GL_ACCT_GROUP_KEY { get; set; }

        public bool SHOW_TITLE_PAID_AT_OTHER_LOCATIONS { get; set; }

        public bool ENABLE_STORE_CREDIT_FOR_INTERNET_LOANS { get; set; }

        [StringLength(8)]
        public string BUSINESS_ENTITY { get; set; }

        public bool ENABLE_LOAN_PAYMENT_PRO { get; set; }

        [Required]
        [StringLength(25)]
        public string LOAN_PAYMENT_PRO_SOURCE_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string LOAN_PAYMENT_PRO_SOURCE_KEY { get; set; }

        [Required]
        [StringLength(25)]
        public string LOAN_PAYMENT_PRO_PIN { get; set; }

        public bool ENABLE_REPAY { get; set; }

        [Required]
        [StringLength(25)]
        public string REPAY_STORE_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string REPAY_USERNAME { get; set; }

        [Required]
        [StringLength(25)]
        public string REPAY_PASSWORD { get; set; }

        public short AIM_MIN_LOAN_RECORDS { get; set; }

        public short AIM_MIN_DM_RECORDS { get; set; }

        public bool ENABLE_CASHED_CHECK_BARCODE_PAGE_PRINT { get; set; }

        public short? LIEN_ADDRESS_LOCATION { get; set; }

        public bool ENABLE_TELLER_CASH_COUNT { get; set; }

        public bool UPDATE_OPEN_LOANS_WITH_NEW_CARD { get; set; }

        public bool ENABLE_STATE_NEW_APP_REQUIRED { get; set; }

        public bool ENABLE_WIRE_TRANSFER_MATCHING { get; set; }

        public short DAYS_TO_REREQUEST_EXPENSES { get; set; }

        public bool ENABLE_FOREIGN_ADDRESSES { get; set; }

        public bool ENABLE_SERVICE_BOX { get; set; }

        public bool ENABLE_DECISION_LOGIC { get; set; }

        public bool MAX_COLLECTIONS_ATTEMPTS_PER_REPRESENTMENT_ENABLED { get; set; }

        public int MAX_COLLECTIONS_ATTEMPTS_SPAY { get; set; }

        public int MAX_COLLECTIONS_ATTEMPTS_MPAY { get; set; }

        public int MAX_COLLECTIONS_ATTEMPTS_OEND { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACH_History> ACH_History { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACH_HistoryCashedCheck> ACH_HistoryCashedCheck { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACH_Sent> ACH_Sent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACHBankConfigException> ACHBankConfigExceptions { get; set; }

        public virtual AlternateLender AlternateLender { get; set; }

        public virtual CABLender CABLender { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CashedCheck> CashedChecks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CCardRespons> CCardResponses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CollectionAction> CollectionActions { get; set; }

        public virtual US_States US_States { get; set; }

        public virtual Currency Currency { get; set; }

        public virtual GLAcctGroup GLAcctGroup { get; set; }

        public virtual Market Market { get; set; }

        public virtual CompanyDetail CompanyDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyDocumentResource> CompanyDocumentResources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyExpenseType> CompanyExpenseTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CurrencyExchangeConfig> CurrencyExchangeConfigs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CurrencyExchangeTran> CurrencyExchangeTrans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerDocument> CustomerDocuments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerFeedback> CustomerFeedbacks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerLeadLocation> CustomerLeadLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepositBag> DepositBags { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepositChk> DepositChks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiscountLocation> DiscountLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExcludeFromCapsHistory> ExcludeFromCapsHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiftCard> GiftCards { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoldConfig> GoldConfigs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoldTran> GoldTrans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImageCashLetterDetail> ImageCashLetterDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncomeTypeLocation> IncomeTypeLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncomeVerifyMethodLocation> IncomeVerifyMethodLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Issuer> Issuers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Issuer> Issuers1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Loan> Loans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Loan> Loans1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanDueDateChange> LoanDueDateChanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanPayment> LoanPayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductBlocked> LoanProductBlockeds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductConfigLoanStat> LoanProductConfigLoanStats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductEnableNewLoan> LoanProductEnableNewLoans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductEnableNewLoan> LoanProductEnableNewLoans1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductRollover> LoanProductRollovers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationUS_ZipcodesXRef> LocationUS_ZipcodesXRef { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhoneSkillsCall> PhoneSkillsCalls { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrepaidCardBinCompany> PrepaidCardBinCompanies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrepaidCardTran> PrepaidCardTrans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductOpenLoanMatrix> ProductOpenLoanMatrices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RISREPT> RISREPTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SkipTraceStep_Location> SkipTraceStep_Location { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TitleLoan> TitleLoans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransferFundsInterStore> TransferFundsInterStores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransferFundsInterStore> TransferFundsInterStores1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaultMgrAssignment> VaultMgrAssignments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaultMgrAuthorization> VaultMgrAuthorizations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehicle> Vehicles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebLoanCreditFraud> WebLoanCreditFrauds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetter> FormLetters { get; set; }
    }
}
