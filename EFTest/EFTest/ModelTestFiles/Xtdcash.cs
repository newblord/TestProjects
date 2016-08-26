namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xtdcash")]
    public partial class Xtdcash
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tdkey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tdcashkey { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TRANS_DETAIL_CASH_KEY { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TRANS_DETAIL_KEY { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string CASH_FROM { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string CASH_TO { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal CASH_AMT { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "smallmoney")]
        public decimal CCARD_AMT { get; set; }

        public int? PARSE_CASH_KEY { get; set; }

        public int? DRAWER_KEY { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CURRENCY_KEY { get; set; }
    }
}
