namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PayStub")]
    public partial class PayStub
    {
        [Key]
        public int PAYSTUB_KEY { get; set; }

        public int LOAN_APPLICATION_KEY { get; set; }

        public int VISITOR_KEY { get; set; }

        [Required]
        [StringLength(25)]
        public string CHECK_NUMBER { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CHECK_AMOUNT { get; set; }

        [Column(TypeName = "date")]
        public DateTime CHECK_DATE { get; set; }

        [Required]
        [StringLength(1)]
        public string PAY_TYPE { get; set; }

        [Required]
        [StringLength(1)]
        public string PAY_CYCLE { get; set; }

        [Column(TypeName = "date")]
        public DateTime PAY_PERIOD_ENDING { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal REGULAR_HOURS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal REGULAR_RATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal OVERTIME_HOURS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal OVERTIME_RATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal GROSS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal GROSS_YTD { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TAXABLE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal FEDERAL_TAX { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal STATE_TAX { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal SOCIAL_SECURITY_TAX { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal MEDICARE_TAX { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public int? IMAGE_TRANSDETAIL_KEY { get; set; }

        public virtual LoanApplication LoanApplication { get; set; }

        public virtual TransDetail TransDetail { get; set; }

        public virtual Visitor Visitor { get; set; }
    }
}
