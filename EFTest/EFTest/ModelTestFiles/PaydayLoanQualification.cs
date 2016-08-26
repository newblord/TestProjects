namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaydayLoanQualification")]
    public partial class PaydayLoanQualification
    {
        [Key]
        public int PAYDAY_LOAN_QUALIFICATION_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public short LOCATION { get; set; }

        public bool BANK_STATEMENT { get; set; }

        public bool BANK_DIRECT_DEPOSIT { get; set; }

        public bool BANK_CONTACTED { get; set; }

        public bool INCOME_STATEMENT { get; set; }

        public bool INCOME_PAY_STUB { get; set; }

        public bool INCOME_DEPOSITS { get; set; }

        public bool HOME_PHONE_WORKING { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
