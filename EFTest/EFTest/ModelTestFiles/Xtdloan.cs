namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xtdloan")]
    public partial class Xtdloan
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tdkey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tdloankey { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TRANS_DETAIL_LOAN_KEY { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TRANS_DETAIL_KEY { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOCATION { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string LOAN_FROM { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(1)]
        public string LOAN_TO { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(1)]
        public string LOAN_TYPE { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "smallmoney")]
        public decimal LOAN_AMT { get; set; }

        [Key]
        [Column(Order = 9)]
        public byte LOAN_CNT { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(1)]
        public string PRODUCT_TYPE { get; set; }
    }
}
