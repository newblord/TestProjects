namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransDetailCash")]
    public partial class TransDetailCash
    {
        [Key]
        [Column(Order = 0)]
        public int TRANS_DETAIL_CASH_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TRANS_DETAIL_KEY { get; set; }

        [Required]
        [StringLength(1)]
        public string CASH_FROM { get; set; }

        [Required]
        [StringLength(1)]
        public string CASH_TO { get; set; }

        [Column(TypeName = "money")]
        public decimal CASH_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CCARD_AMT { get; set; }

        public int? PARSE_CASH_KEY { get; set; }

        public int? DRAWER_KEY { get; set; }

        public int CURRENCY_KEY { get; set; }

        public virtual Currency Currency { get; set; }

        public virtual ParseCash ParseCash { get; set; }

        public virtual TransDetail TransDetail { get; set; }
    }
}
