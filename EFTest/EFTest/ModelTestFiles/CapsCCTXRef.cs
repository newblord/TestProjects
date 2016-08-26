namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CapsCCTXRef")]
    public partial class CapsCCTXRef
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CREDIT_CARD_TRANS_KEY { get; set; }

        public int CAPS_HOLD_KEY { get; set; }

        public bool APPROVED { get; set; }

        public bool POSTED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal AMT { get; set; }

        public virtual CapsHold CapsHold { get; set; }
    }
}
