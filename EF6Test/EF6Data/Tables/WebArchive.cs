namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebArchive")]
    public partial class WebArchive
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebArchive()
        {
            WebCallRecordingArchives = new HashSet<WebCallRecordingArchive>();
        }

        [Key]
        public int WEB_ARCHIVE_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string DESCRIPTION { get; set; }

        [Required]
        [StringLength(100)]
        public string PATH { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallRecordingArchive> WebCallRecordingArchives { get; set; }
    }
}
