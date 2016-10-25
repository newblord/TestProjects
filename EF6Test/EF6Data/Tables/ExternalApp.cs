namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ExternalApp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExternalApp()
        {
            ExternalAppConfigs = new HashSet<ExternalAppConfig>();
            ExternalAppRunDates = new HashSet<ExternalAppRunDate>();
        }

        [Key]
        public int EXTERNAL_APPS_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string APP_NAME { get; set; }

        [StringLength(100)]
        public string APP_INSTANCE { get; set; }

        [StringLength(300)]
        public string APP_DESCRIPTION { get; set; }

        [StringLength(50)]
        public string CMD_NAMED_ARG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExternalAppConfig> ExternalAppConfigs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExternalAppRunDate> ExternalAppRunDates { get; set; }
    }
}
