namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_CashedCheckRateTable
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string CHK_RATE_CODE { get; set; }

        [StringLength(20)]
        public string CHK_RATE_DESC { get; set; }

        public bool? USE_RATE_TABLE { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal LOCATION { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MIN_FEE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CHK_RATE_FEE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CHK_RATE_PCT { get; set; }

        [Column(TypeName = "money")]
        public decimal? CHK_RATE_MAX { get; set; }
    }
}
