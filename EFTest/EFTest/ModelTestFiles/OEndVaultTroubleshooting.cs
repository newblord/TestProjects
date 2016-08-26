namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OEndVaultTroubleshooting")]
    public partial class OEndVaultTroubleshooting
    {
        public DateTime? TIME_STAMP { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOCATION { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "money")]
        public decimal INV_AMT { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "money")]
        public decimal VLT_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal? AMT_DIFF { get; set; }

        public int? INV_CNT { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short VLT_CNT { get; set; }

        public int? CNT_DIFF { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string LOAN_TYPE { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string PRODUCT_TYPE { get; set; }

        public int? LIEN_TYPE { get; set; }
    }
}
