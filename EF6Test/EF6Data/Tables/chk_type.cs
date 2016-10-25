namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class chk_type
    {
        [Key]
        [StringLength(1)]
        public string chk_code { get; set; }

        [Column("chk_type")]
        [StringLength(20)]
        public string chk_type1 { get; set; }
    }
}
