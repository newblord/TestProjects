namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OptPlusExportTransCode
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string TRANS_CODE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string TRECS_CODE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(12)]
        public string D2JE1D { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(12)]
        public string D2JE1C { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(12)]
        public string D2JE2D { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(12)]
        public string D2JE2C { get; set; }
    }
}
