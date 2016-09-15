namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xccp")]
    public partial class Xccp
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ccpkey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cckey { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tdkey { get; set; }

        [StringLength(50)]
        public string Spell_TRANS_CODE { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ckey { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CASHED_CHECK_PAYMENT_KEY { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CASHED_CHECK_KEY { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TRANS_DETAIL_KEY { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOCATION { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(500)]
        public string NOTE { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "smallmoney")]
        public decimal PAID_AMT { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool REVERSED { get; set; }

        public DateTime? REVERSED_DATE { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short PAYMENT_METHOD { get; set; }

        [Key]
        [Column(Order = 14)]
        public byte TRANS_CODE { get; set; }
    }
}
