namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xlpsp")]
    public partial class Xlpsp
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lpspkey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lpkey { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lkey { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tdkey { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ckey { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short lp_LOCATION { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(1)]
        public string lp_PRODUCT_TYPE { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(1)]
        public string lp_LOAN_TYPE { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "smallmoney")]
        public decimal lp_PAID_AMT { get; set; }

        [Key]
        [Column(Order = 9)]
        public byte lp_TRANS_CODE { get; set; }

        [StringLength(50)]
        public string Spell_TRANS_CODE { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short lp_PAYMENT_METHOD { get; set; }

        [StringLength(15)]
        public string Spell_PAYMENT_METHOD { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool lp_REVERSED { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(3)]
        public string lp_TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? lp_REVERSED_DATE { get; set; }

        [Key]
        [Column(Order = 13)]
        public DateTime lp_DATE_ENTERED { get; set; }

        [Column(TypeName = "date")]
        public DateTime? lp_DATE_ENTERED_no_time { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_PAYMENT_SPAY_KEY { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_PAYMENT_KEY { get; set; }

        [Key]
        [Column(Order = 16, TypeName = "smallmoney")]
        public decimal COLL_FEE_DUE_PAID_AMT { get; set; }

        [Key]
        [Column(Order = 17, TypeName = "smallmoney")]
        public decimal LEGAL_FEE_DUE_PAID_AMT { get; set; }

        [Key]
        [Column(Order = 18, TypeName = "smallmoney")]
        public decimal LOAN_FEE_DUE_PAID_AMT { get; set; }

        [Key]
        [Column(Order = 19, TypeName = "smallmoney")]
        public decimal INTEREST_DUE_PAID_AMT { get; set; }

        [Key]
        [Column(Order = 20, TypeName = "smallmoney")]
        public decimal CAB_INTEREST_DUE_PAID_AMT { get; set; }

        [Key]
        [Column(Order = 21, TypeName = "smallmoney")]
        public decimal PRINC_DUE_PAID_AMT { get; set; }

        [Key]
        [Column(Order = 22, TypeName = "smallmoney")]
        public decimal CAB_LENDER_COLL_FEE_PAST_DUE_PAID_AMT { get; set; }

        [Key]
        [Column(Order = 23, TypeName = "smallmoney")]
        public decimal NSF_FEE_DUE_PAID_AMT { get; set; }
    }
}
