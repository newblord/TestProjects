namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DocumentSigningStatu
    {
        [Key]
        public int DOCUMENT_SIGNING_STATUS_KEY { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public int? LOAN_APPLICATION_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string GENERATED_PIN { get; set; }

        public bool IS_PIN_VALIDATED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? VALIDATED_DATE { get; set; }

        public virtual LoanApplication LoanApplication { get; set; }

        public virtual Loan Loan { get; set; }
    }
}
