namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RIPTPPaymentPlanConfig")]
    public partial class RIPTPPaymentPlanConfig
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RIPTPPaymentPlanConfig()
        {
            PromiseToPays = new HashSet<PromiseToPay>();
        }

        [Key]
        public int PTP_CONFIG_KEY { get; set; }

        [Required]
        [StringLength(30)]
        public string PTP_PLAN_NAME { get; set; }

        [Required]
        [StringLength(36)]
        public string PTP_PL_TYPES { get; set; }

        [StringLength(1000)]
        public string PTP_LOCATIONS { get; set; }

        [Required]
        [StringLength(50)]
        public string PTP_PAYMENT_METHODS { get; set; }

        public byte PTP_MAX_NUMBER_PAYMENTS { get; set; }

        public short PTP_MAX_NUMBER_PLAN_DAYS { get; set; }

        public byte PTP_DEFAULT_PAYMENT_NUMBER { get; set; }

        public short PTP_FIRST_PAYMENT_PERCENT { get; set; }

        public short PTP_MAX_DAYS_EXT_DAYS { get; set; }

        public short PTP_DEF_DAYS_BETWEEN_PMTS { get; set; }

        public short PTP_GRACE_DAYS { get; set; }

        public bool PTP_ALLOW_WAIVE_FEE { get; set; }

        public bool PTP_MOD_APPROVAL_REQ { get; set; }

        public bool PTP_DM_CRM_APPROVAL_REQ { get; set; }

        public short? PTP_AUDIT_CATEGORY { get; set; }

        [StringLength(100)]
        public string SECURITY { get; set; }

        public bool EXTENDED_PAYMENT_PLAN { get; set; }

        public bool STATE_SPECIFIC_PAYMENT_PLAN { get; set; }

        public bool IS_INTERNET { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal BROKEN_PTP_FEE { get; set; }

        public bool IS_LOAN_MATURED { get; set; }

        public bool IS_LOAN_INACTIVE { get; set; }

        public bool IS_LOAN_NOT_MATURED { get; set; }

        public bool IS_LOAN_NOT_INACTIVE { get; set; }

        public byte PTP_MIN_NUMBER_PAYMENTS { get; set; }

        public bool REQUIRE_SIGNATURE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PromiseToPay> PromiseToPays { get; set; }
    }
}
