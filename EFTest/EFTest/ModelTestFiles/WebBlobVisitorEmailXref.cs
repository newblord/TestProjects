namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebBlobVisitorEmailXref")]
    public partial class WebBlobVisitorEmailXref
    {
        [Key]
        public int WEB_BLOB_VISITOR_EMAIL_XREF_KEY { get; set; }

        public int WEB_BLOB_KEY { get; set; }

        public int VISITOR_EMAIL_KEY { get; set; }

        [Required]
        [StringLength(256)]
        public string DESCRIPTION { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(200)]
        public string ATTACHMENT_NAME { get; set; }

        public virtual VisitorEmail VisitorEmail { get; set; }

        public virtual WebBlob WebBlob { get; set; }
    }
}
