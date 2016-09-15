namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xssrd")]
    public partial class Xssrd
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ssrdkey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ssrkey { get; set; }

        public int? ahkey { get; set; }

        public int? tdkey { get; set; }

        public int? clpkey { get; set; }

        public int? vlpkey { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lkey { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int zrlkey { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ckey { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string ssrd { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SPAY_SCHED_ROLLOVER_DETAIL_KEY { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SPAY_SCHED_ROLLOVER_KEY { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "smalldatetime")]
        public DateTime ROLLOVER_DATE { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "smallmoney")]
        public decimal OPT_BUYDOWN_AMT { get; set; }

        [Key]
        [Column(Order = 10)]
        public byte ROLLOVER_NUM { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "smallmoney")]
        public decimal LOAN_AMT { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "smallmoney")]
        public decimal PRINC_AMT { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "smallmoney")]
        public decimal LOAN_ATR { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "smalldatetime")]
        public DateTime DUE_DATE { get; set; }

        public int? ACH_HISTORY_KEY { get; set; }

        public int? TRANS_DETAIL_KEY { get; set; }

        public int? CANCEL_LOAN_PAYMENT_KEY { get; set; }

        public int? VOID_LOAN_PAYMENT_KEY { get; set; }

        public int? SCHED_LOAN_PAYMENT_KEY { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(1)]
        public string ssr { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_KEY { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ZERO_REC_LOAN_KEY { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CUSTOMER_KEY { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_PAYMENT_KEY { get; set; }

        [Key]
        [Column(Order = 20)]
        public byte NUM_ROLLOVERS { get; set; }
    }
}
