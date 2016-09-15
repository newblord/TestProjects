namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanImport")]
    public partial class LoanImport
    {
        [Key]
        public int LOAN_IMPORT_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Required]
        [StringLength(50)]
        public string COMPANY_NAME { get; set; }

        [Required]
        [StringLength(255)]
        public string CUSTOMER_IMPORT_FILE { get; set; }

        [Required]
        [StringLength(255)]
        public string LOAN_IMPORT_FILE { get; set; }
    }
}
