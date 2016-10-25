namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DDIEditHistory")]
    public partial class DDIEditHistory
    {
        [Key]
        public int DDI_EDIT_HISTORY_KEY { get; set; }

        public int DDI_KEY { get; set; }

        [Required]
        [StringLength(30)]
        public string FIELD_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string OLD_VALUE { get; set; }

        [Required]
        [StringLength(100)]
        public string NEW_VALUE { get; set; }

        public DateTime ENTERED_DATE { get; set; }

        public virtual DDI DDI { get; set; }
    }
}
