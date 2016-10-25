namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SPaySchedRolloverDetail")]
    public partial class SPaySchedRolloverDetail
    {
        [Key]
        public int SPAY_SCHED_ROLLOVER_DETAIL_KEY { get; set; }

        public int SPAY_SCHED_ROLLOVER_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ROLLOVER_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal OPT_BUYDOWN_AMT { get; set; }

        public byte ROLLOVER_NUM { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_ATR { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DUE_DATE { get; set; }

        public int? ACH_HISTORY_KEY { get; set; }

        public int? TRANS_DETAIL_KEY { get; set; }

        public int? CANCEL_LOAN_PAYMENT_KEY { get; set; }

        public int? VOID_LOAN_PAYMENT_KEY { get; set; }

        public int? SCHED_LOAN_PAYMENT_KEY { get; set; }

        public virtual SPaySchedRollover SPaySchedRollover { get; set; }
    }
}
