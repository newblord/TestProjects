namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AppValue")]
    public partial class AppValue
    {
        [Key]
        public short APP_VALUE_KEY { get; set; }

        public short APP_CONFIG_KEY { get; set; }

        public short APP_SETTING_KEY { get; set; }

        [StringLength(1000)]
        public string APP_VALUE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime LAST_UPDATED { get; set; }

        [Required]
        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        public virtual AppConfig AppConfig { get; set; }

        public virtual AppSetting AppSetting { get; set; }
    }
}
