namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProcessConfigDetail")]
    public partial class ProcessConfigDetail
    {
        [Key]
        public int PROCESS_CONFIG_DETAIL_KEY { get; set; }

        public int PROCESS_CONFIG_INSTANCE_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string CONFIG_NAME { get; set; }

        [Required]
        public string CONFIG_VALUE { get; set; }

        public virtual ProcessConfigInstance ProcessConfigInstance { get; set; }
    }
}
