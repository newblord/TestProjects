namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebBlobLoanXref")]
    public partial class WebBlobLoanXref
    {
        [Key]
        public int WEB_BLOB_LOAN_XREF_KEY { get; set; }

        public int WEB_BLOB_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        [Required]
        [StringLength(256)]
        public string DESCRIPTION { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public virtual Loan Loan { get; set; }

        public virtual WebBlob WebBlob { get; set; }
    }
}
