namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CreditCardBlock")]
    public partial class CreditCardBlock
    {
        [Key]
        public int CREDIT_CARD_BLOCK_KEY { get; set; }

        public int BLOCK_REASON_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_ENTERED { get; set; }

        public bool IS_TOKEN { get; set; }

        public short? CREDIT_CARD_RESULT_CODE_KEY { get; set; }

        public int COUNT_AT_BLOCK { get; set; }

        [StringLength(40)]
        public string CARD_NUM { get; set; }

        public virtual BlockReason BlockReason { get; set; }
    }
}
