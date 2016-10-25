namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RbcEFundBatch")]
    public partial class RbcEFundBatch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RbcEFundBatch()
        {
            RbcEFundBatchDetails = new HashSet<RbcEFundBatchDetail>();
            RbcEFundBatchSummaries = new HashSet<RbcEFundBatchSummary>();
        }

        [Key]
        public int RBC_EFUND_BATCH_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public short DETAIL_COUNT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal DETAIL_VALUE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RESPONSE_DATE { get; set; }

        [Required]
        [StringLength(50)]
        public string SEND_FILE_NAME { get; set; }

        public bool FILE_WRITTEN { get; set; }

        public bool ACCEPTED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RbcEFundBatchDetail> RbcEFundBatchDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RbcEFundBatchSummary> RbcEFundBatchSummaries { get; set; }
    }
}
