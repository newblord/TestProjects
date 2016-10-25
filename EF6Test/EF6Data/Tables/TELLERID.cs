namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TELLERID")]
    public partial class TELLERID
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TELLERID()
        {
            DocumentResources = new HashSet<DocumentResource>();
            DocumentResources1 = new HashSet<DocumentResource>();
            ReasonForArrears = new HashSet<ReasonForArrear>();
            RiUrgentNotes = new HashSet<RiUrgentNote>();
            TellerSecurities = new HashSet<TellerSecurity>();
        }

        [StringLength(3)]
        public string TELLER { get; set; }

        [Required]
        [StringLength(10)]
        public string PASSWORD { get; set; }

        [Required]
        [StringLength(20)]
        public string FIRSTNAME { get; set; }

        [Required]
        [StringLength(15)]
        public string LSTNAME { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LAST_LOGIN { get; set; }

        public short location { get; set; }

        public int SECURITYGROUP_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LastPWChg { get; set; }

        [StringLength(30)]
        public string RSAPassword { get; set; }

        [StringLength(12)]
        public string SWIPE_ID { get; set; }

        public bool DisplayReleaseInfo { get; set; }

        [Required]
        [StringLength(9)]
        public string SSN { get; set; }

        [Required]
        [StringLength(10)]
        public string ADP_ID { get; set; }

        public bool AUDIT_REQUIRED { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HIRE_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CERT_DATE { get; set; }

        [StringLength(3)]
        public string CERT_BY { get; set; }

        public short LAST_LOCATION { get; set; }

        public bool ACCOUNT_LOCKED { get; set; }

        public byte ATTEMPTS { get; set; }

        [Key]
        public int TELLER_ID_KEY { get; set; }

        public int? LAST_SELECTED_CUSTOMER_KEY { get; set; }

        public int? LAST_SELECTED_LOAN_KEY { get; set; }

        [Required]
        [StringLength(500)]
        public string LOCATION_LISTVIEW_COLUMNS { get; set; }

        [Required]
        [StringLength(40)]
        public string LOCATION_LISTVIEW_COLUMN_WIDTHS { get; set; }

        [Required]
        [StringLength(40)]
        public string LOCATION_LISTVIEW_SORT { get; set; }

        public bool SHOW_OPS_NEWS { get; set; }

        public byte QUESTION_ATTEMPTS { get; set; }

        public byte TELLER_TYPE { get; set; }

        public int? TITLE_KEY { get; set; }

        [StringLength(20)]
        public string SAM_ACCOUNT_NAME { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CASHCOUNT_START_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CASHCOUNT_END_DATE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentResource> DocumentResources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentResource> DocumentResources1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReasonForArrear> ReasonForArrears { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RiUrgentNote> RiUrgentNotes { get; set; }

        public virtual SecurityGroup SecurityGroup { get; set; }

        public virtual SecurityGroup SecurityGroup1 { get; set; }

        public virtual TellerType TellerType { get; set; }

        public virtual TellerTitle TellerTitle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TellerSecurity> TellerSecurities { get; set; }
    }
}
