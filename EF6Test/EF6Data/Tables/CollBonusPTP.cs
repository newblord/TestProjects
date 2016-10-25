namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CollBonusPTP")]
    public partial class CollBonusPTP
    {
        public int? PTP_DETAIL_KEY { get; set; }

        public int? RISREPT_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        [StringLength(1)]
        public string PRODUCT_TYPE { get; set; }

        [StringLength(1)]
        public string LOAN_TYPE { get; set; }

        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_ENTERED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? AMOUNT { get; set; }

        public byte? PTP_TYPE { get; set; }

        public short? LOCATION { get; set; }

        [Key]
        public int COLL_BONUS_PTP_KEY { get; set; }
    }
}
