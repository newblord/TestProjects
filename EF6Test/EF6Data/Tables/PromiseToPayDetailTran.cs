namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PromiseToPayDetailTran
    {
        [Key]
        public int PTP_DETAIL_TRANS_KEY { get; set; }

        public int PTP_DETAIL_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PTP_AMOUNT { get; set; }

        public bool REVERSED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? REVERSED_DATE { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        public virtual PromiseToPayDetail PromiseToPayDetail { get; set; }

        public virtual TransDetail TransDetail { get; set; }
    }
}
