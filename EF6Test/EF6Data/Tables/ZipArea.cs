namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZipArea")]
    public partial class ZipArea
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string ZIPCODE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string AREA { get; set; }
    }
}
