namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xtdcheck")]
    public partial class Xtdcheck
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tdkey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tdcheckkey { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TRANS_DETAIL_CHECK_KEY { get; set; }

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
        public string CHECK_FROM { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(1)]
        public string CHECK_TO { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "smallmoney")]
        public decimal CHECK_AMT { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short CHECK_QTY { get; set; }

        [Key]
        [Column(Order = 9)]
        public byte CHECK_TYPE { get; set; }

        public int? DRAWER_KEY { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(1)]
        public string DEPOSIT_METHOD { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(1)]
        public string X { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "smalldatetime")]
        public DateTime TD_DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short TD_LOCATION { get; set; }

        [Key]
        [Column(Order = 14)]
        public byte TD_TRANS_CODE { get; set; }

        [StringLength(50)]
        public string Spell_TD_TRANS_CODE { get; set; }
    }
}
