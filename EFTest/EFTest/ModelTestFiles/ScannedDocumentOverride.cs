namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ScannedDocumentOverride")]
    public partial class ScannedDocumentOverride
    {
        [Key]
        public int SCANNED_DOCUMENT_OVERRIDE_KEY { get; set; }

        public int SCANNED_DOCUMENT_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Required]
        [StringLength(1)]
        public string CODE { get; set; }

        public virtual ScannedDocument ScannedDocument { get; set; }
    }
}
