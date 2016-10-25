namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocuwareCabinet")]
    public partial class DocuwareCabinet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocuwareCabinet()
        {
            DocuwareLoanLkups = new HashSet<DocuwareLoanLkup>();
        }

        [Key]
        public int DOCUWARE_CABINET_KEY { get; set; }

        public short SERVER_ID { get; set; }

        [Required]
        [StringLength(64)]
        public string CABINET_DB_TABLE { get; set; }

        [StringLength(128)]
        public string DW_REFERENCE_LOOKUP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocuwareLoanLkup> DocuwareLoanLkups { get; set; }
    }
}
