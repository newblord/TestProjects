namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Visitor")]
    public partial class Visitor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Visitor()
        {
            AMLOccupations = new HashSet<AMLOccupation>();
            Customers = new HashSet<Customer>();
            LoanApplications = new HashSet<LoanApplication>();
            LoanApplicationAffordSurvey_ToBeDeleted = new HashSet<LoanApplicationAffordSurvey_ToBeDeleted>();
            LoanApplicationExpenses = new HashSet<LoanApplicationExpense>();
            OOWSessions = new HashSet<OOWSession>();
            OptInOuts = new HashSet<OptInOut>();
            PayStubs = new HashSet<PayStub>();
            SMSInbounds = new HashSet<SMSInbound>();
            SMSOutbounds = new HashSet<SMSOutbound>();
            VisitorApiAuthorizations = new HashSet<VisitorApiAuthorization>();
            VisitorDevices = new HashSet<VisitorDevice>();
            VisitorEdits = new HashSet<VisitorEdit>();
            VisitorEmails = new HashSet<VisitorEmail>();
            VisitorHistories = new HashSet<VisitorHistory>();
            WebCallAuthorizedVisitorContacts = new HashSet<WebCallAuthorizedVisitorContact>();
            WebCallQueues = new HashSet<WebCallQueue>();
            WebCallWorkQueues = new HashSet<WebCallWorkQueue>();
            WebErrorLogs = new HashSet<WebErrorLog>();
            WebVisits = new HashSet<WebVisit>();
            WebVisitSources = new HashSet<WebVisitSource>();
            ZeroDollarAuths = new HashSet<ZeroDollarAuth>();
        }

        [Key]
        public int VISITOR_KEY { get; set; }

        public byte LENDER_KEY { get; set; }

        [StringLength(60)]
        public string EMAIL_ADDR { get; set; }

        [Required]
        [StringLength(75)]
        public string PASSWORD { get; set; }

        public bool IS_PASSWORD_SYS_GEN { get; set; }

        public int SIGNIN_COUNT { get; set; }

        [Required]
        [StringLength(1)]
        public string V_STATUS_ID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LAST_UPDATED { get; set; }

        public byte FAILED_LOGIN_COUNT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LAST_LOGIN { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LAST_FAILED_LOGIN { get; set; }

        public int? VISITOR_SECURITY_QUESTION_KEY { get; set; }

        [StringLength(255)]
        public string SECURITY_ANSWER { get; set; }

        public int EMAIL_DELIVERY_FAILURE_COUNT { get; set; }

        public DateTime EMAIL_DELIVERY_FAILURE_DATE { get; set; }

        public bool INVALID_EMAIL { get; set; }

        public bool EMAIL_DELETED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EMAIL_DELETED_DATE { get; set; }

        [StringLength(3)]
        public string EMAIL_DELETED_BY { get; set; }

        public bool BLOCKED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [StringLength(60)]
        public string ACCESS_ID { get; set; }

        [StringLength(75)]
        public string ACCESS_PASSWORD { get; set; }

        public int? BLOCK_REASON_KEY { get; set; }

        public byte PASSWORD_TYPE { get; set; }

        [StringLength(50)]
        public string SALT { get; set; }

        public byte OOW_STATUS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OOW_DATE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AMLOccupation> AMLOccupations { get; set; }

        public virtual BlockReason BlockReason { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }

        public virtual Lender Lender { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplication> LoanApplications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplicationAffordSurvey_ToBeDeleted> LoanApplicationAffordSurvey_ToBeDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplicationExpense> LoanApplicationExpenses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OOWSession> OOWSessions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptInOut> OptInOuts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PayStub> PayStubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SMSInbound> SMSInbounds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SMSOutbound> SMSOutbounds { get; set; }

        public virtual VisitorSecurityQuestion VisitorSecurityQuestion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitorApiAuthorization> VisitorApiAuthorizations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitorDevice> VisitorDevices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitorEdit> VisitorEdits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitorEmail> VisitorEmails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitorHistory> VisitorHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallAuthorizedVisitorContact> WebCallAuthorizedVisitorContacts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallQueue> WebCallQueues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallWorkQueue> WebCallWorkQueues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebErrorLog> WebErrorLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebVisit> WebVisits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebVisitSource> WebVisitSources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZeroDollarAuth> ZeroDollarAuths { get; set; }
    }
}
