namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACHDetail")]
    public partial class ACHDetail
    {
        [Key]
        public int ACH_DETAIL_KEY { get; set; }

        [StringLength(1)]
        public string RECORD_TYPE { get; set; }

        [StringLength(2)]
        public string TRANS_CODE { get; set; }

        [StringLength(8)]
        public string PARTICIPANT_ROUTING_NUMBER { get; set; }

        public short? PARTICIPANT_ROUTING_NUMBER_CHECK_DIGIT { get; set; }

        [StringLength(17)]
        public string PARTICIPANT_ACCOUNT_NUMBER { get; set; }

        [StringLength(10)]
        public string TRANSACTION_AMOUNT { get; set; }

        [StringLength(15)]
        public string IDENITIFICATION_NUMBER { get; set; }

        [StringLength(22)]
        public string RECEIVER_NAME { get; set; }

        [StringLength(2)]
        public string DISCRETIONARY_DATA { get; set; }

        [StringLength(1)]
        public string ADDENDA_RECORD { get; set; }

        [StringLength(15)]
        public string TRACE_NUMBER { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EFFECTIVE_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PROCESS_DATE { get; set; }

        public bool? SELECTED { get; set; }

        public bool? PROCESSED { get; set; }

        public int? ACH_RETURN_CODE_KEY { get; set; }

        public int ACH_BATCH_HEADER_KEY { get; set; }

        public virtual ACHBatchHeader ACHBatchHeader { get; set; }

        public virtual ACHDetailAddendum ACHDetailAddendum { get; set; }
    }
}
