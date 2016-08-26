namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExternalAppConfig")]
    public partial class ExternalAppConfig
    {
        [Key]
        public int EXTERNAL_APP_CONFIG_KEY { get; set; }

        public int EXTERNAL_APPS_KEY { get; set; }

        [Required]
        [StringLength(30)]
        public string CONFIG_NAME { get; set; }

        [Required]
        [StringLength(1000)]
        public string CONFIG_VALUE { get; set; }

        public virtual ExternalApp ExternalApp { get; set; }
    }
}
