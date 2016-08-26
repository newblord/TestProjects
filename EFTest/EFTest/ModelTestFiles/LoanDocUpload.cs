namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanDocUpload")]
    public partial class LoanDocUpload
    {
        [Key]
        public int LOAN_DOC_UPLOAD_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime UPLOAD_DATE { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public short LOCATION { get; set; }

        public int LOAN_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string LOAN_DOC_FILE_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string ZIP_FILE_NAME { get; set; }
    }
}
