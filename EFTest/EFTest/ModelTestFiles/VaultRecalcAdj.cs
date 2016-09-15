namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VaultRecalcAdj")]
    public partial class VaultRecalcAdj
    {
        [Key]
        public int VAULT_RECALC_ADJ_KEY { get; set; }

        public short LOCATION { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Required]
        [StringLength(40)]
        public string FIELD_NAME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VAULT_AMT { get; set; }

        public int VAULT_CNT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CALC_AMT { get; set; }

        public int CALC_CNT { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? AMT_DIFF { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? CNT_DIFF { get; set; }
    }
}
