namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACHAck")]
    public partial class ACHAck
    {
        [Key]
        public int ACH_ACK_KEY { get; set; }

        public int ACH_SENT_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string FILE_NAME { get; set; }

        public bool FILE_REJECTED { get; set; }

        public int REJECT_ITEM_COUNT { get; set; }

        [Column(TypeName = "money")]
        public decimal REJECT_CREDIT_AMT { get; set; }

        public int TOTAL_ITEM_COUNT { get; set; }

        [Column(TypeName = "money")]
        public decimal TOTAL_CREDIT_AMT { get; set; }

        public DateTime DATE_ENTERED { get; set; }
    }
}
