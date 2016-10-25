namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xtd")]
    public partial class Xtd
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tdkey { get; set; }

        public int? ckey { get; set; }

        public int? tpkey { get; set; }

        [StringLength(50)]
        public string Spell_TRANS_CODE { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TRANS_DETAIL_KEY { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOCATION { get; set; }

        public int? TRANS_POS_KEY { get; set; }

        public int? DRAWERZ_KEY { get; set; }

        public int? REVERSE_KEY { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        [Key]
        [Column(Order = 5)]
        public byte TRANS_CODE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(1)]
        public string PRODUCT_TYPE { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(1)]
        public string LOAN_TYPE { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(1)]
        public string X { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? tp_CASH_RECV { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? tp_CASH_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? tp_CCARD_RECV { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? tp_CCARD_PAID { get; set; }
    }
}
