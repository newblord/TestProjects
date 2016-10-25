namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RiBalanceHistory")]
    public partial class RiBalanceHistory
    {
        [Key]
        public int RI_BALANCE_HISTORY_KEY { get; set; }

        public int RISREPT_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal RI_BALANCE { get; set; }

        public virtual RISREPT RISREPT { get; set; }
    }
}
