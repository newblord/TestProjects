namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanProductConfigInterestRate")]
    public partial class LoanProductConfigInterestRate
    {
        [Key]
        public int LOAN_PRODUCT_CONFIG_INTEREST_RATE_KEY { get; set; }

        public int LOAN_PRODUCT_CONFIG_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_UP_TO_AMT { get; set; }

        public decimal INTEREST_RATE_PCT { get; set; }

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
