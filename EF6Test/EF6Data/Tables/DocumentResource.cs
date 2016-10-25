namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentResource")]
    public partial class DocumentResource
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocumentResource()
        {
            CompanyDocumentResources = new HashSet<CompanyDocumentResource>();
        }

        [Key]
        public int DOCUMENT_RESOURCE_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string RESOURCE_NAME { get; set; }

        [Required]
        public byte[] DATA { get; set; }

        public short MIME_TYPE_KEY { get; set; }

        public bool IS_ACTIVE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CREATED_DATETIME { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime UPDATED_DATETIME { get; set; }

        public int CREATED_BY { get; set; }

        public int UPDATED_BY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyDocumentResource> CompanyDocumentResources { get; set; }

        public virtual TELLERID TELLERID { get; set; }

        public virtual MimeType MimeType { get; set; }

        public virtual TELLERID TELLERID1 { get; set; }
    }
}
