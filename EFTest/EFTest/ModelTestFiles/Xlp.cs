namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xlp")]
    public partial class Xlp
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lpKey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lKey { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tdKey { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cKey { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime de { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOCATION { get; set; }

        [Key]
        [Column(Order = 7)]
        public byte TRANS_CODE { get; set; }

        [StringLength(50)]
        public string Spell_TRANS_CODE { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "smallmoney")]
        public decimal PAID_AMT { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short PAYMENT_METHOD { get; set; }

        [StringLength(15)]
        public string Spell_PAYMENT_METHOD { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool REVERSED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? REVERSED_DATE { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(500)]
        public string NOTE { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(1)]
        public string PRODUCT_TYPE { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(1)]
        public string LOAN_TYPE { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(1)]
        public string x { get; set; }

        public int? lprKey { get; set; }

        public int? lpr_tdKey { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(1)]
        public string y { get; set; }

        public int? lpdaoKey { get; set; }

        [StringLength(1)]
        public string DECREASE_AMOUNT_OWED_TYPE { get; set; }

        [StringLength(1)]
        public string DECREASE_AMOUNT_OWED_REASON { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? APPLY_BUCKET_AMT { get; set; }

        [StringLength(1)]
        public string APPLY_DUE_TYPE { get; set; }

        [StringLength(1)]
        public string APPLY_BUCKET_TYPE { get; set; }

        [StringLength(15)]
        public string Spell_BUCKET_TYPE { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(1)]
        public string z { get; set; }

        public int? lpddKey { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ORIG_DUE_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ADJUSTED_DUE_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PAST_DUE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PENDING_ACH_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? COLLECTIONS_AMT { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(1)]
        public string xx { get; set; }

        [Column(TypeName = "date")]
        public DateTime? de_notime { get; set; }

        [Key]
        [Column(Order = 18)]
        public bool rev { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_KEY { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_PAYMENT_KEY { get; set; }
    }
}
