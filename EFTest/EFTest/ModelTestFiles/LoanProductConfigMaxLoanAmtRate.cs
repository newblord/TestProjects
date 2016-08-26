namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanProductConfigMaxLoanAmtRate")]
    public partial class LoanProductConfigMaxLoanAmtRate
    {
        [Key]
        public int LOAN_PRODUCT_CONFIG_MAX_LOAN_AMT_RATE_KEY { get; set; }

        public int LOAN_PRODUCT_CONFIG_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INCOME_REQUIRED_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_AMT_MAX_AMT { get; set; }

        public byte LOAN_LENGTH_MAX_MONTHS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_UPDATED { get; set; }

        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        public virtual LoanProductConfig LoanProductConfig { get; set; }
    }
}
