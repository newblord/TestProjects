namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanDoc")]
    public partial class LoanDoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoanDoc()
        {
            LoanDocPrinteds = new HashSet<LoanDocPrinted>();
            LoanDocUseds = new HashSet<LoanDocUsed>();
            ScannedDocuments = new HashSet<ScannedDocument>();
        }

        [Key]
        public int LOAN_DOC_KEY { get; set; }

        public byte LOAN_DOC_TYPE_KEY { get; set; }

        [Required]
        [StringLength(20)]
        public string LOAN_DOC_FILENAME { get; set; }

        [Required]
        [StringLength(10)]
        public string LOAN_DOC_EXT { get; set; }

        [Required]
        [StringLength(8)]
        public string LOAN_DOC_REVISION { get; set; }

        [Column(TypeName = "image")]
        public byte[] LOAN_DOC_FILE { get; set; }

        [Required]
        [StringLength(2)]
        public string LOAN_DOC_STATE { get; set; }

        [Required]
        [StringLength(1)]
        public string LOAN_DOC_LANGUAGE { get; set; }

        public bool LOAN_DOC_ENABLED { get; set; }

        public bool PRINT_ONLY_MILITARY { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public virtual LoanDocType LoanDocType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanDocPrinted> LoanDocPrinteds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanDocUsed> LoanDocUseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScannedDocument> ScannedDocuments { get; set; }
    }
}
