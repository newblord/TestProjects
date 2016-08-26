namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CapsHold")]
    public partial class CapsHold
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CapsHold()
        {
            CapsCCTXRefs = new HashSet<CapsCCTXRef>();
        }

        [Key]
        public int CAPS_HOLD_KEY { get; set; }

        public int CAPS_RUN_KEY { get; set; }

        public int RISREPT_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public int CASHED_CHECK_KEY { get; set; }

        public int OPTPLUS_CARD_DETAIL_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public int ISSUER_KEY { get; set; }

        public int PTP_HEADER_KEY { get; set; }

        public int PTP_DETAIL_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RETURN_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DUE_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal AMT_TO_COLLECT { get; set; }

        [Required]
        [StringLength(1)]
        public string DEPOSIT_METHOD { get; set; }

        public int DEPOSIT_ORDER { get; set; }

        [Required]
        [StringLength(50)]
        public string BILLING_ADDRESS { get; set; }

        [Required]
        [StringLength(30)]
        public string BILLING_CITY { get; set; }

        [Required]
        [StringLength(2)]
        public string BILLING_STATE { get; set; }

        [Required]
        [StringLength(10)]
        public string BILLING_ZIPCODE { get; set; }

        public short LOCATION { get; set; }

        public int? RIS_AUDIT_ID { get; set; }

        public int CREDITCARD_KEY { get; set; }

        [StringLength(19)]
        public string CARDNUM { get; set; }

        [Required]
        [StringLength(50)]
        public string NAMEONCARD { get; set; }

        public byte EXPMONTH { get; set; }

        public int EXPYEAR { get; set; }

        [Required]
        [StringLength(40)]
        public string TOKEN { get; set; }

        public byte CARD_BRAND { get; set; }

        public byte CARD_TYPE { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Required]
        [StringLength(1)]
        public string LOAN_TYPE { get; set; }

        [Required]
        [StringLength(1)]
        public string PRODUCT_TYPE { get; set; }

        public bool IS_AD_ASTRA { get; set; }

        public bool SELECTED { get; set; }

        public bool PROCESSED { get; set; }

        public bool APPROVED { get; set; }

        public bool POSTED { get; set; }

        [Required]
        [StringLength(100)]
        public string APP_ERR_CODE { get; set; }

        public byte CAPS_SKIP_REASON_KEY { get; set; }

        public int RI_AGE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LAST_DCARD_ATTEMPT_DATE { get; set; }

        public int? DCARD_CONSECUTIVE_DAYS { get; set; }

        public int? LAST_CCTRANS_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? AMT_COLLECTED { get; set; }

        public bool EXCLUDE_FROM_CAP { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOT_FEE_AMT { get; set; }

        [StringLength(20)]
        public string CAPS_ATTEMPT_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CALC_PAY_DATE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CapsCCTXRef> CapsCCTXRefs { get; set; }

        public virtual CapsSkipReason CapsSkipReason { get; set; }
    }
}
