namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DCardChargeBackXRef")]
    public partial class DCardChargeBackXRef
    {
        [Key]
        public int DCARD_CHARGE_BACK_XREF_KEY { get; set; }

        public int REFUND_TRANS_DETAIL_KEY { get; set; }

        public int REFUNDED_TRANS_DETAIL_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CHARGE_BACK_AMOUNT { get; set; }

        public virtual TransDetail TransDetail { get; set; }

        public virtual TransDetail TransDetail1 { get; set; }
    }
}
