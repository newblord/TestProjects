namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CheckType")]
    public partial class CheckType
    {
        [Key]
        public int CHECK_TYPE_KEY { get; set; }

        [Required]
        [StringLength(1)]
        public string CHECK_TYPE_CODE { get; set; }

        [StringLength(20)]
        public string CHECK_TYPE_DESC { get; set; }
    }
}
