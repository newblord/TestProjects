namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanApplicationIncome")]
    public partial class LoanApplicationIncome
    {
        [Key]
        public int LOAN_APPLICATION_INCOME_KEY { get; set; }

        public int LOAN_APPLICATION_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Required]
        [StringLength(1)]
        public string AMOUNT_TYPE { get; set; }

        [Required]
        [StringLength(1)]
        public string AMOUNT_CYCLE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INCOME_AMOUNT { get; set; }

        public int LOAN_APPLICATION_EMPLOYER_KEY { get; set; }

        public int? INCOME_VERIFY_METHOD_KEY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATE_VERIFIED { get; set; }

        public virtual LoanApplication LoanApplication { get; set; }

        public virtual LoanApplicationEmployer LoanApplicationEmployer { get; set; }
    }
}
