namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransDetailCashParsedCash")]
    public partial class TransDetailCashParsedCash
    {
        [Key]
        public int TRANS_DETAIL_CASH_PARSED_CASH_KEY { get; set; }

        public int TRANS_DETAIL_CASH_KEY { get; set; }

        public int DENOMINATION_KEY { get; set; }

        [Column(TypeName = "money")]
        public decimal AMOUNT { get; set; }

        public virtual Denomination Denomination { get; set; }
    }
}
