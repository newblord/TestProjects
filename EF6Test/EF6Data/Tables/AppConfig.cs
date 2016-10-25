namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AppConfig")]
    public partial class AppConfig
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AppConfig()
        {
            AppValues = new HashSet<AppValue>();
        }

        [Key]
        public short APP_CONFIG_KEY { get; set; }

        [Required]
        [StringLength(25)]
        public string APP_CONFIG_NAME { get; set; }

        [Required]
        [StringLength(300)]
        public string DESCRIPTION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppValue> AppValues { get; set; }
    }
}
