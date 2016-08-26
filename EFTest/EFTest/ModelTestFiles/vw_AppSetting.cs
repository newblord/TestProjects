namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_AppSetting
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short APP_CONFIG_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string APP_CONFIG_NAME { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(300)]
        public string DESCRIPTION { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short APP_SETTING_KEY { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string APP_SETTING_NAME { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(300)]
        public string SettingDescription { get; set; }

        public short? APP_VALUE_KEY { get; set; }

        [StringLength(1000)]
        public string APP_VALUE { get; set; }
    }
}
