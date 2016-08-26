namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_CashedCheckRate
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string CHK_RATE_CODE { get; set; }

        [StringLength(20)]
        public string CHK_RATE_DESC { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "smallmoney")]
        public decimal CHK_RATE_FEE { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal CHK_RATE_PCT { get; set; }

        public bool? USE_RATE_TABLE { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal LOCATION { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MIN_FEE { get; set; }
    }
}
