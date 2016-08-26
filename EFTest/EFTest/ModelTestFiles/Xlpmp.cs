namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xlpmp")]
    public partial class Xlpmp
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lpmpkey { get; set; }

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
        public DateTime de { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_PAYMENT_MPAY_KEY { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_PAYMENT_KEY { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool ADD_TO_COLL { get; set; }

        [Key]
        [Column(Order = 18)]
        public bool REM_FROM_COLL { get; set; }

        [Key]
        [Column(Order = 19, TypeName = "smallmoney")]
        public decimal PENDING_SCHED_ACH_AMT { get; set; }

        [Key]
        [Column(Order = 20)]
        public bool IS_CO_EARLY_PAYOFF_REBATE { get; set; }

        [Key]
        [Column(Order = 21, TypeName = "smallmoney")]
        public decimal COLL_FEE_PAST_DUE_PAID { get; set; }

        [Key]
        [Column(Order = 22, TypeName = "smallmoney")]
        public decimal LEGAL_FEE_PAST_DUE_PAID { get; set; }

        [Key]
        [Column(Order = 23, TypeName = "smallmoney")]
        public decimal LOAN_FEE_DUE_PAID { get; set; }

        [Key]
        [Column(Order = 24, TypeName = "smallmoney")]
        public decimal TRANS_FEE_DUE_PAID { get; set; }

        [Key]
        [Column(Order = 25, TypeName = "smallmoney")]
        public decimal INTEREST_DUE_PAID { get; set; }

        [Key]
        [Column(Order = 26, TypeName = "smallmoney")]
        public decimal PRINC_DUE_PAID { get; set; }

        [Key]
        [Column(Order = 27, TypeName = "smallmoney")]
        public decimal PAYMENT_DUE_PAID { get; set; }

        [Key]
        [Column(Order = 28, TypeName = "smallmoney")]
        public decimal PAYMENT_PAST_DUE_PAID { get; set; }

        [Key]
        [Column(Order = 29, TypeName = "smallmoney")]
        public decimal CAB_COLL_FEE_PAST_DUE_PAID { get; set; }

        [Key]
        [Column(Order = 30, TypeName = "smallmoney")]
        public decimal CAB_INTEREST_DUE_PAID { get; set; }

        [Key]
        [Column(Order = 31)]
        public bool IS_SCHEDULED_PAYMENT { get; set; }

        [Key]
        [Column(Order = 32)]
        public bool IS_DAY_AFTER_DUE_PAYMENT { get; set; }

        [Key]
        [Column(Order = 33, TypeName = "smallmoney")]
        public decimal NSF_FEE_PAST_DUE_PAID { get; set; }

        [Key]
        [Column(Order = 34, TypeName = "smallmoney")]
        public decimal INSURANCE_DUE_PAID { get; set; }
    }
}
