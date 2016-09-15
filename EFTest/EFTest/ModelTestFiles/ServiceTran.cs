namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ServiceTran
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServiceTran()
        {
            CourtesyPayouts = new HashSet<CourtesyPayout>();
            ServiceTransDetails = new HashSet<ServiceTransDetail>();
        }

        [Key]
        public int SERVICE_TRANS_KEY { get; set; }

        public int SERVICE_DETAIL_KEY { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        public int? MO_STATUS_KEY { get; set; }

        public short LOCATION { get; set; }

        public short QTY_SOLD { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal SERVICE_FEE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal SERVICE_AMT { get; set; }

        public int? GL_ACCT_FEE { get; set; }

        public int? GL_ACCT_AMT { get; set; }

        public byte PAYMENT_METHOD { get; set; }

        public bool REVERSED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? REVERSED_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? CALC_EXTEND { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourtesyPayout> CourtesyPayouts { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ServiceDetail ServiceDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceTransDetail> ServiceTransDetails { get; set; }
    }
}
