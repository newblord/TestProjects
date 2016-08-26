namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ScannedDocument")]
    public partial class ScannedDocument
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ScannedDocument()
        {
            ScannedDocumentOverrides = new HashSet<ScannedDocumentOverride>();
        }

        [Key]
        public int SCANNED_DOCUMENT_KEY { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        public int? LOAN_DOC_KEY { get; set; }

        public int? DOCUMENT_SYSTEM_KEY { get; set; }

        public DateTime? DOCUMENT_SYSTEM_SCAN_DATE { get; set; }

        public virtual LoanDoc LoanDoc { get; set; }

        public virtual TransDetail TransDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScannedDocumentOverride> ScannedDocumentOverrides { get; set; }
    }
}
