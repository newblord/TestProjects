namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallUserSetting")]
    public partial class WebCallUserSetting
    {
        [Key]
        public int WEB_CALL_USER_SETTING_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string USER { get; set; }

        [Required]
        [StringLength(50)]
        public string SETTING { get; set; }

        [Required]
        [StringLength(2000)]
        public string VALUE { get; set; }
    }
}
