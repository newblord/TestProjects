namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanCreditLimit")]
    public partial class LoanCreditLimit
    {
        [Key]
        public int LOAN_CREDIT_LIMIT_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal OLD_LIMIT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_LIMIT { get; set; }
    }
}
