namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OverShort")]
    public partial class OverShort
    {
        [Key]
        public int OS_KEY { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public short LOCATION { get; set; }

        public int? DRAWERZ_KEY { get; set; }

        public int? VAULT_COUNT_KEY { get; set; }

        public int? SERVICE_DETAIL_KEY { get; set; }

        [Column(TypeName = "money")]
        public decimal CALC_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal ENTERED_AMT { get; set; }

        public int? CALC_QTY { get; set; }

        public int? ENTERED_QTY { get; set; }

        [Column(TypeName = "money")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? AMT_OVER { get; set; }

        [Column(TypeName = "money")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? AMT_SHORT { get; set; }

        public int? CURRENCY_KEY { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? QTY_OVER { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? QTY_SHORT { get; set; }

        public virtual DrawerZ DrawerZ { get; set; }

        public virtual ServiceDetail ServiceDetail { get; set; }

        public virtual TransDetail TransDetail { get; set; }

        public virtual VaultCount VaultCount { get; set; }
    }
}
