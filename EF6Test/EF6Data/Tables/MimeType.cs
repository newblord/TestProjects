namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MimeType")]
    public partial class MimeType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MimeType()
        {
            DocumentResources = new HashSet<DocumentResource>();
        }

        [Key]
        public short MIME_TYPE_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string MIME_TYPE { get; set; }

        [StringLength(10)]
        public string FILE_EXTENSION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentResource> DocumentResources { get; set; }
    }
}
