namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanProductConfigInsuranceRate")]
    public partial class LoanProductConfigInsuranceRate
    {
        [Key]
        public int LOAN_PRODUCT_CONFIG_INSURANCE_RATE_KEY { get; set; }

        public int LOAN_PRODUCT_CONFIG_KEY { get; set; }

        public decimal FEE_PER_PAYMENT_PCT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_UP_TO_AMT { get; set; }

        [Required]
        [StringLength(1)]
        public string PAYMENT_CYCLE { get; set; }

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
