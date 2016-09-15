namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebBlobLoanApplicationXref")]
    public partial class WebBlobLoanApplicationXref
    {
        [Key]
        public int WEB_BLOB_LOAN_APPLICATION_XREF_KEY { get; set; }

        public int WEB_BLOB_KEY { get; set; }

        public int LOAN_APPLICATION_KEY { get; set; }

        [Required]
        [StringLength(256)]
        public string DESCRIPTION { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(2085)]
        public string SOURCE_URL { get; set; }

        public virtual LoanApplication LoanApplication { get; set; }

        public virtual WebBlob WebBlob { get; set; }
    }
}
