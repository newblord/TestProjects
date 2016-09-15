namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebBlob")]
    public partial class WebBlob
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebBlob()
        {
            WebBlobLoanApplicationXrefs = new HashSet<WebBlobLoanApplicationXref>();
            WebBlobLoanXrefs = new HashSet<WebBlobLoanXref>();
            WebBlobVisitorEmailXrefs = new HashSet<WebBlobVisitorEmailXref>();
        }

        [Key]
        public int WEB_BLOB_KEY { get; set; }

        [Required]
        public byte[] DATA { get; set; }

        public short WEB_BLOB_TYPE_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public virtual WebBlobType WebBlobType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebBlobLoanApplicationXref> WebBlobLoanApplicationXrefs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebBlobLoanXref> WebBlobLoanXrefs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebBlobVisitorEmailXref> WebBlobVisitorEmailXrefs { get; set; }
    }
}
