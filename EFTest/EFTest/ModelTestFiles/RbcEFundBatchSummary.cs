namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RbcEFundBatchSummary")]
    public partial class RbcEFundBatchSummary
    {
        [Key]
        public int RBC_EFUND_BATCH_SUMMARY_KEY { get; set; }

        public int RBC_EFUND_BATCH_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal SUCCESS_AMOUNT { get; set; }

        public short SUCCESS_COUNT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal UNSUCCESS_AMOUNT { get; set; }

        public short UNSUCCESS_COUNT { get; set; }

        public bool PROCESSED { get; set; }

        public virtual RbcEFundBatch RbcEFundBatch { get; set; }
    }
}
