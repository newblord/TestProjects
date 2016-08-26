namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RbcEFundResponseCode")]
    public partial class RbcEFundResponseCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RbcEFundResponseCode()
        {
            RbcEFundBatchDetails = new HashSet<RbcEFundBatchDetail>();
        }

        [Key]
        public int RBC_EFUND_RESPONSE_CODE_KEY { get; set; }

        [Required]
        [StringLength(5)]
        public string RBC_CODE { get; set; }

        [Required]
        [StringLength(300)]
        public string DESCRIPTION { get; set; }

        [Required]
        [StringLength(300)]
        public string COMMENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RbcEFundBatchDetail> RbcEFundBatchDetails { get; set; }
    }
}
