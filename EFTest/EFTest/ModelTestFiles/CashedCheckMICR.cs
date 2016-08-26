namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CashedCheckMICR")]
    public partial class CashedCheckMICR
    {
        [Key]
        public int CASHED_CHECK_MICR_KEY { get; set; }

        public int CASHED_CHECK_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string MICRDATA { get; set; }

        [Required]
        [StringLength(30)]
        public string AUX_ON_US { get; set; }

        [Required]
        [StringLength(30)]
        public string TRANSIT_NUMBER { get; set; }

        [Required]
        [StringLength(1)]
        public string EXTERNAL_PROCESSING_CODE { get; set; }

        [Required]
        [StringLength(1)]
        public string CHECKSUM_DIGIT { get; set; }

        [Required]
        [StringLength(30)]
        public string ON_US { get; set; }

        [Required]
        [StringLength(30)]
        public string MICR_AMOUNT { get; set; }

        [Required]
        [StringLength(100)]
        public string DEPOSIT_BANK_CONTROL_DATA { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public virtual CashedCheck CashedCheck { get; set; }
    }
}
