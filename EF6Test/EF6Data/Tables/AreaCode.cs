namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AreaCode")]
    public partial class AreaCode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AREA_CODE { get; set; }

        [Required]
        [StringLength(2)]
        public string STATE { get; set; }
    }
}
