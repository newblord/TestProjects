namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanApplication")]
    public partial class LoanApplication
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoanApplication()
        {
            CustomerLeads = new HashSet<CustomerLead>();
            DocumentSigningStatus = new HashSet<DocumentSigningStatu>();
            ErrorLogs = new HashSet<ErrorLog>();
            ExperianCardValidations = new HashSet<ExperianCardValidation>();
            FurtherFinanceExecutionLogs = new HashSet<FurtherFinanceExecutionLog>();
            FurtherFinanceResults = new HashSet<FurtherFinanceResult>();
            LoanApplicationAddresses = new HashSet<LoanApplicationAddress>();
            LoanApplicationAffordSurvey_ToBeDeleted = new HashSet<LoanApplicationAffordSurvey_ToBeDeleted>();
            LoanApplicationDiscounts = new HashSet<LoanApplicationDiscount>();
            LoanApplicationExpenses = new HashSet<LoanApplicationExpense>();
            LoanApplicationIncomes = new HashSet<LoanApplicationIncome>();
            LoanApplicationProducts = new HashSet<LoanApplicationProduct>();
            LoanApplicationVehicleInformations = new HashSet<LoanApplicationVehicleInformation>();
            PayStubs = new HashSet<PayStub>();
            SMSInbounds = new HashSet<SMSInbound>();
            SMSOutbounds = new HashSet<SMSOutbound>();
            VisitorEmails = new HashSet<VisitorEmail>();
            WebBlobLoanApplicationXrefs = new HashSet<WebBlobLoanApplicationXref>();
            WebCallQueues = new HashSet<WebCallQueue>();
            WebCallWorkQueues = new HashSet<WebCallWorkQueue>();
            WebErrorLogs = new HashSet<WebErrorLog>();
            WebImages = new HashSet<WebImage>();
            WebPixelVendorDatas = new HashSet<WebPixelVendorData>();
            WebVisits = new HashSet<WebVisit>();
            WebVisitSources = new HashSet<WebVisitSource>();
        }

        [Key]
        public int LOAN_APPLICATION_KEY { get; set; }

        public byte LENDER_KEY { get; set; }

        public short LOCATION { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        public int? VISITOR_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        [Required]
        [StringLength(25)]
        public string FIRST_NAME { get; set; }

        [Required]
        [StringLength(25)]
        public string MID_NAME { get; set; }

        [Required]
        [StringLength(25)]
        public string LAST_NAME { get; set; }

        [Required]
        [StringLength(12)]
        public string HOME_PHONE { get; set; }

        [Required]
        [StringLength(12)]
        public string CELL_PHONE { get; set; }

        [Required]
        [StringLength(9)]
        public string SSN { get; set; }

        [Required]
        [StringLength(9)]
        public string ABA_NUM { get; set; }

        [Required]
        [StringLength(20)]
        public string ACCT_NUM { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal REQ_CASH_AMT { get; set; }

        [StringLength(18)]
        public string CCARD_NUM { get; set; }

        [Required]
        [StringLength(4)]
        public string CCARD_CVV { get; set; }

        public byte CCARD_EXP_MONTH { get; set; }

        public short CCARD_EXP_YEAR { get; set; }

        public bool CCARD_IS_DEBIT { get; set; }

        [Required]
        [StringLength(50)]
        public string CCARD_NAME_ON_CARD { get; set; }

        [Required]
        [StringLength(1)]
        public string LANGUAGE { get; set; }

        public int STATUS { get; set; }

        [Required]
        [StringLength(1000)]
        public string REASON_DENIED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NEXT_PAY_DATE { get; set; }

        [StringLength(3)]
        public string TELLER { get; set; }

        [StringLength(40)]
        public string ID_NO { get; set; }

        [StringLength(50)]
        public string SPOUSE_FIRST_NAME { get; set; }

        [StringLength(50)]
        public string SPOUSE_MID_NAME { get; set; }

        [StringLength(50)]
        public string SPOUSE_LAST_NAME { get; set; }

        [StringLength(9)]
        public string SPOUSE_SSN { get; set; }

        [StringLength(12)]
        public string SPOUSE_HOME_PHONE { get; set; }

        [StringLength(12)]
        public string SPOUSE_CELL_PHONE { get; set; }

        [StringLength(50)]
        public string SPOUSE_WORK_NAME { get; set; }

        [StringLength(12)]
        public string SPOUSE_WORK_PHONE { get; set; }

        [StringLength(10)]
        public string SPOUSE_WORK_PHONE_EXT { get; set; }

        [StringLength(1)]
        public string GENDER { get; set; }

        public bool? BOUNCED { get; set; }

        [StringLength(1)]
        public string HOW_REF_OBSOLETE { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(50)]
        public string REF1_FIRST_NAME { get; set; }

        [StringLength(50)]
        public string REF1_LAST_NAME { get; set; }

        [StringLength(12)]
        public string REF1_PHONE { get; set; }

        [StringLength(1)]
        public string REF1_RELATIONSHIP { get; set; }

        [StringLength(50)]
        public string REF2_FIRST_NAME { get; set; }

        [StringLength(50)]
        public string REF2_LAST_NAME { get; set; }

        [StringLength(12)]
        public string REF2_PHONE { get; set; }

        [StringLength(1)]
        public string REF2_RELATIONSHIP { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? RI_BALANCE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RI_FOLLOWUP { get; set; }

        public byte? OWN_RENT_OTHER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RESIDENCE_SINCE { get; set; }

        [StringLength(10)]
        public string LEGAL_NUMBER { get; set; }

        [StringLength(1)]
        public string COURTESY_CALL_NUM { get; set; }

        [StringLength(40)]
        public string CUST_ID_NUM { get; set; }

        [StringLength(15)]
        public string CUST_ID_SOURCE { get; set; }

        [StringLength(30)]
        public string CUST_ID_VERIFY_OTHER { get; set; }

        public bool? ACTIVE_MILITARY { get; set; }

        public bool? MILITARY_MEMBER { get; set; }

        public bool? MILITARY_ACTIVE_DUTY { get; set; }

        public bool? MILITARY_COMBAT_DUTY { get; set; }

        public bool? MILITARY_RESERVE_NOT_ACTIVE { get; set; }

        public bool? MILITARY_RESERVE_ACTIVE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? MONTHLY_HOUSING { get; set; }

        public bool? INET_APPROVED { get; set; }

        public bool? CC_BLOCK { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DOB { get; set; }

        [Required]
        [StringLength(1)]
        public string SOURCE_APP { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(1)]
        public string SOURCE_DB { get; set; }

        public int WEB_REFERRAL_METHOD_KEY_OBSOLETE { get; set; }

        public byte CC_COUNT { get; set; }

        [Required]
        [StringLength(15)]
        public string IP_ADDRESS { get; set; }

        public byte MARITAL_STATUS { get; set; }

        public bool? JOINT_LOAN { get; set; }

        public short REFERRAL_METHOD_KEY { get; set; }

        public int? PENNY_AUTH_KEY { get; set; }

        [StringLength(40)]
        public string VEH_MAKE { get; set; }

        [StringLength(100)]
        public string VEH_MODEL { get; set; }

        public short? VEH_YEAR { get; set; }

        [StringLength(40)]
        public string VEH_VIN { get; set; }

        [StringLength(30)]
        public string VEH_LIEN_HOLDER_NAME { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? VEH_LIEN_BALANCE { get; set; }

        public bool? VEH_LEASED { get; set; }

        public bool? ARBITRATION_OPT_IN { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CCARD_GUARANTEE_AMT { get; set; }

        [StringLength(40)]
        public string CCARD_TOKEN { get; set; }

        [StringLength(1)]
        public string FUNDING_TYPE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CCARD_FROM_DATE { get; set; }

        public byte? CCARD_ISSUE_NUM { get; set; }

        public byte CCARD_BRAND { get; set; }

        public byte CCARD_TYPE { get; set; }

        public bool IS_EPDQ_ONLY { get; set; }

        public int TITLE { get; set; }

        public int? CUST_ID_TYPE_KEY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CUST_ID_EXP_DATE { get; set; }

        [StringLength(3)]
        public string CUST_ID_COUNTRY { get; set; }

        [StringLength(2)]
        public string CUST_ID_STATE { get; set; }

        public int? CUST_ID_VERIFY_KEY { get; set; }

        public short? DEPENDENTS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CANCEL_INSURANCE_REQUEST_DATE { get; set; }

        [StringLength(3)]
        public string CANCEL_INSURANCE_REQUEST_BY { get; set; }

        public virtual CreditCardTran CreditCardTran { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerLead> CustomerLeads { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentSigningStatu> DocumentSigningStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ErrorLog> ErrorLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExperianCardValidation> ExperianCardValidations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FurtherFinanceExecutionLog> FurtherFinanceExecutionLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FurtherFinanceResult> FurtherFinanceResults { get; set; }

        public virtual IdentificationTypeVerify IdentificationTypeVerify { get; set; }

        public virtual Lender Lender { get; set; }

        public virtual Loan Loan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplicationAddress> LoanApplicationAddresses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplicationAffordSurvey_ToBeDeleted> LoanApplicationAffordSurvey_ToBeDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplicationDiscount> LoanApplicationDiscounts { get; set; }

        public virtual PersonTitle PersonTitle { get; set; }

        public virtual ReferralMethod ReferralMethod { get; set; }

        public virtual Visitor Visitor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplicationExpense> LoanApplicationExpenses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplicationIncome> LoanApplicationIncomes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplicationProduct> LoanApplicationProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplicationVehicleInformation> LoanApplicationVehicleInformations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PayStub> PayStubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SMSInbound> SMSInbounds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SMSOutbound> SMSOutbounds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitorEmail> VisitorEmails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebBlobLoanApplicationXref> WebBlobLoanApplicationXrefs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallQueue> WebCallQueues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallWorkQueue> WebCallWorkQueues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebErrorLog> WebErrorLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebImage> WebImages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebPixelVendorData> WebPixelVendorDatas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebVisit> WebVisits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebVisitSource> WebVisitSources { get; set; }
    }
}
