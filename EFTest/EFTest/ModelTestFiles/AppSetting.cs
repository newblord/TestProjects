namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AppSetting")]
    public partial class AppSetting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AppSetting()
        {
            AppValues = new HashSet<AppValue>();
        }

        [Key]
        public short APP_SETTING_KEY { get; set; }

        [Required]
        [StringLength(20)]
        public string APP_SETTING_NAME { get; set; }

        [Required]
        [StringLength(300)]
        public string DESCRIPTION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppValue> AppValues { get; set; }
    }
}
