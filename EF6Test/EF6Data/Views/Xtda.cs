namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xtda")]
    public partial class Xtda
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tdkey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tdakey { get; set; }

        public int? tpkey { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TRANS_DETAIL_ACCT_KEY { get; set; }

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
        public byte ACCT_TYPE { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal AMOUNT { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GL_ACCT { get; set; }

        [Column(TypeName = "money")]
        public decimal? DEBIT { get; set; }

        [Column(TypeName = "money")]
        public decimal? CREDIT { get; set; }

        [StringLength(30)]
        public string Spell_ACCT_TYPE { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(2)]
        public string GL { get; set; }

        [StringLength(50)]
        public string gl_DESCRIPTON { get; set; }

        public bool? gl_IS_ADASTRA { get; set; }

        public bool? gl_IS_TITLE_TYPE { get; set; }

        public bool? gl_IS_NON_CASH_ACCT { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(2)]
        public string TD { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "smalldatetime")]
        public DateTime td_DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short td_LOCATION { get; set; }

        [Key]
        [Column(Order = 12)]
        public byte td_TRANS_CODE { get; set; }

        [StringLength(50)]
        public string Spell_td_TRANS_CODE { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(1)]
        public string td_PRODUCT_TYPE { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(1)]
        public string td_LOAN_TYPE { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(2)]
        public string TP { get; set; }

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
