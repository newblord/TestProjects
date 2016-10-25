namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_QuickAndDirtyChkRates
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string STATE { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CHK_RATE_CODE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(17)]
        public string CHK_RATE_DESC { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CHK_RATE_FEE { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "numeric")]
        public decimal CHK_RATE_PCT { get; set; }
    }
}
