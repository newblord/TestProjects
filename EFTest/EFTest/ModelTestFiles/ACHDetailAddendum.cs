namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACHDetailAddendum")]
    public partial class ACHDetailAddendum
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ACH_DETAIL_ADDENDUM_KEY { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ACH_DETAIL_KEY { get; set; }

        [Required]
        [StringLength(1)]
        public string RECORD_TYPE { get; set; }

        [Required]
        [StringLength(2)]
        public string ADDENDA_TYPE_CODE { get; set; }

        [StringLength(3)]
        public string RETURN_NOC_CODE { get; set; }

        [Required]
        [StringLength(15)]
        public string ORIGINAL_TRACE_NUMBER { get; set; }

        [StringLength(6)]
        public string DATE_OF_DEATH { get; set; }

        [Required]
        [StringLength(8)]
        public string ORIGINAL_RFDI_RT_NUMBER { get; set; }

        [StringLength(44)]
        public string ADDENDA_INFORMATION { get; set; }

        [StringLength(15)]
        public string TRACE_NUMBER { get; set; }

        public virtual ACHDetail ACHDetail { get; set; }
    }
}
