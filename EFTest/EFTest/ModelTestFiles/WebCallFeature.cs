namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WebCallFeature
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebCallFeature()
        {
            WebCallRARRFeatures = new HashSet<WebCallRARRFeature>();
        }

        [Key]
        public int WEB_CALL_FEATURES_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        public byte DISPLAY_ORDER { get; set; }

        public bool SupDualAuthEnabled { get; set; }

        public bool CSRDualAuthEnabled { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallRARRFeature> WebCallRARRFeatures { get; set; }
    }
}
