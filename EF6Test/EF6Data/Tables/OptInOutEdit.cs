namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OptInOutEdit")]
    public partial class OptInOutEdit
    {
        [Key]
        public int OPTINOUT_EDIT_KEY { get; set; }

        public int OPTINOUT_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLERID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(50)]
        public string FIELD_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string OLD_VALUE { get; set; }

        [Required]
        [StringLength(50)]
        public string NEW_VALUE { get; set; }

        public virtual OptInOut OptInOut { get; set; }
    }
}
