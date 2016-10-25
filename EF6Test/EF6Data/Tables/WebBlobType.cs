namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebBlobType")]
    public partial class WebBlobType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebBlobType()
        {
            WebBlobs = new HashSet<WebBlob>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short WEB_BLOB_TYPE_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string TYPE { get; set; }

        [Required]
        [StringLength(128)]
        public string DESCRIPTION { get; set; }

        public bool ACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebBlob> WebBlobs { get; set; }
    }
}
