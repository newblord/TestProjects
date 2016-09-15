namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BillPayBiller")]
    public partial class BillPayBiller
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BillPayBiller()
        {
            BillerOCRRegions = new HashSet<BillerOCRRegion>();
        }

        [Key]
        public int BILLPAY_BILLER_KEY { get; set; }

        public byte VENDOR_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string DISPLAYED_NAME { get; set; }

        [Required]
        [StringLength(6)]
        public string BILLER_CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string BILLER_NAME { get; set; }

        [Required]
        [StringLength(12)]
        public string BILLER_PHONE { get; set; }

        [Required]
        [StringLength(1000)]
        public string RAW_IMPORTED_DATA { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal MAX_ALLOWED_PAYMENT { get; set; }

        public byte STATUS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public decimal? BILLER_FEE { get; set; }

        public bool? USE_BILLER_FEE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillerOCRRegion> BillerOCRRegions { get; set; }
    }
}
