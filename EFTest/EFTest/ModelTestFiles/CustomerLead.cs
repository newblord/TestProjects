namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerLead")]
    public partial class CustomerLead
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerLead()
        {
            CustomerLeadActivities = new HashSet<CustomerLeadActivity>();
            CustomerLeadNotes = new HashSet<CustomerLeadNote>();
        }

        [Key]
        public int CUSTOMER_LEAD_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_ENTERED { get; set; }

        [Required]
        [StringLength(1)]
        public string LEAD_SOURCE { get; set; }

        public short ORIG_LOCATION { get; set; }

        public short SUPERSTORE { get; set; }

        public short? SATELLITE { get; set; }

        public int CUSTOMER_LEAD_STATUS_KEY { get; set; }

        [Column(TypeName = "date")]
        public DateTime STATUS_CHANGE_DATE { get; set; }

        public int? CUSTOMER_LEAD_REASON_KEY { get; set; }

        public int LOAN_APPLICATION_KEY { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        [StringLength(40)]
        public string FIRSTNAME { get; set; }

        [StringLength(10)]
        public string MIDNAME { get; set; }

        [StringLength(24)]
        public string LASTNAME { get; set; }

        [StringLength(9)]
        public string SSN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOB { get; set; }

        [StringLength(10)]
        public string HOME_ADDR_NUM { get; set; }

        [StringLength(2)]
        public string HOME_ADDR_PRE_DIR { get; set; }

        [StringLength(40)]
        public string HOME_ADDR_STREET { get; set; }

        [StringLength(10)]
        public string HOME_ADDR_SUFFIX { get; set; }

        [StringLength(2)]
        public string HOME_ADDR_POST_DIR { get; set; }

        [StringLength(10)]
        public string HOME_ADDR_SUITE { get; set; }

        [StringLength(15)]
        public string HOME_ADDR_SUITE_NUM { get; set; }

        [StringLength(30)]
        public string HOME_CITY { get; set; }

        [StringLength(2)]
        public string HOME_STATE { get; set; }

        [StringLength(10)]
        public string HOME_ZIPCODE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RESIDENCE_SINCE { get; set; }

        public byte? OWNRENTOTHER { get; set; }

        [StringLength(12)]
        public string HOME_PHONE { get; set; }

        [StringLength(12)]
        public string CELL_PHONE { get; set; }

        public int? MOBILE_CARRIER { get; set; }

        [StringLength(12)]
        public string WORK_PHONE { get; set; }

        [StringLength(10)]
        public string WORK_PHONE_EXT { get; set; }

        [StringLength(1)]
        public string PREFERRED_CONTACT { get; set; }

        [StringLength(60)]
        public string EMAIL { get; set; }

        [StringLength(1)]
        public string PAY_CYCLE { get; set; }

        public decimal? GROSS_INCOME { get; set; }

        public decimal? NET_INCOME { get; set; }

        public decimal? PVBD_INCOME { get; set; }

        [StringLength(9)]
        public string ABA_NUM { get; set; }

        [StringLength(20)]
        public string ACCT_NO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? APPT_FOLLOW_DATE { get; set; }

        [StringLength(1)]
        public string APPT_FOLLOW_TIME { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_UPDATED { get; set; }

        [StringLength(3)]
        public string TELLER_UPDATED { get; set; }

        public int? VISITOR_KEY { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string HOME_ADDRESS_LINE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerLeadActivity> CustomerLeadActivities { get; set; }

        public virtual CustomerLeadReason CustomerLeadReason { get; set; }

        public virtual LoanApplication LoanApplication { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerLeadNote> CustomerLeadNotes { get; set; }
    }
}
