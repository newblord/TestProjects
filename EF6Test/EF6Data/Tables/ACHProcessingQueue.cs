namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACHProcessingQueue")]
    public partial class ACHProcessingQueue
    {
        [Key]
        public int ACH_PROCESSING_QUEUE_KEY { get; set; }

        public int LOCATION { get; set; }

        public int LOAN_KEY { get; set; }

        [Column(TypeName = "money")]
        public decimal ACH_AMOUNT { get; set; }

        [Column(TypeName = "date")]
        public DateTime DUE_DATE { get; set; }

        public byte ACH_ATTEMPT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MANUAL_SEND_DATE { get; set; }

        [StringLength(3)]
        public string MANUAL_TELLER { get; set; }

        [Required]
        [StringLength(9)]
        public string ABA_NO { get; set; }

        [Required]
        [StringLength(20)]
        public string BANK_NO { get; set; }

        public bool IS_SCHEDULED_PAYMENT { get; set; }

        public bool IS_AD_ASTRA { get; set; }

        public bool IS_ACH_PAID { get; set; }

        public int? JOB_ID { get; set; }

        public short? ACH_REASON_CODE { get; set; }

        public int? OPTPLUS_CARD_DETAIL_KEY { get; set; }

        [StringLength(20)]
        public string STATEMENT_ID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINC_AMT_FOR_INTEREST_CREDIT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal FEES_AMT_FOR_INTEREST_CREDIT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INTEREST_DUE_CAP { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CAB_INTEREST_DUE_CAP { get; set; }

        public int ACH_BANK_KEY { get; set; }

        [StringLength(15)]
        public string GRAD_NUMBER { get; set; }

        public int ACH_PROCESSING_TYPE_KEY { get; set; }

        public int? ACH_SENT_PARENT_KEY { get; set; }

        public int RUN_MASTER_KEY { get; set; }

        public int? SCHED_ROLLOVER_KEY { get; set; }

        public int? ACH_PRESENTMENT_KEY { get; set; }

        public virtual ACHProcessingType ACHProcessingType { get; set; }

        public virtual ACHReason ACHReason { get; set; }

        public virtual Loan Loan { get; set; }
    }
}
