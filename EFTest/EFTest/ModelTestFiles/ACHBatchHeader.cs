namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACHBatchHeader")]
    public partial class ACHBatchHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACHBatchHeader()
        {
            ACHDetails = new HashSet<ACHDetail>();
        }

        [Key]
        public int ACH_BATCH_HEADER_KEY { get; set; }

        [Required]
        [StringLength(1)]
        public string RECORD_TYPE { get; set; }

        [Required]
        [StringLength(3)]
        public string SERVICE_CLASS_CODE { get; set; }

        [Required]
        [StringLength(16)]
        public string COMPANY_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string COMPANY_DISCRETIONARY_DATA { get; set; }

        [Required]
        [StringLength(10)]
        public string COMPANY_ID { get; set; }

        [Required]
        [StringLength(3)]
        public string SEC_CODE { get; set; }

        [Required]
        [StringLength(10)]
        public string COMPANY_ENTRY_DESCRIPTION { get; set; }

        [Required]
        [StringLength(6)]
        public string COMPANY_DESCRIPTIVE_DATA { get; set; }

        [Required]
        [StringLength(6)]
        public string EFFECTIVE_ENTRY_DATE { get; set; }

        [StringLength(3)]
        public string JULIAN_SETTLEMENT_DATE { get; set; }

        [Required]
        [StringLength(1)]
        public string STATUS_CODE { get; set; }

        [Required]
        [StringLength(8)]
        public string ORIGINATING_DFI_ROUTING_NUMBER { get; set; }

        [Required]
        [StringLength(7)]
        public string BATCH_NUMBER { get; set; }

        public bool PROCESSED_RETURNS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACHDetail> ACHDetails { get; set; }
    }
}
