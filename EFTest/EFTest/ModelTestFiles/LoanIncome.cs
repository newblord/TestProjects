namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanIncome")]
    public partial class LoanIncome
    {
        [Key]
        public int LOAN_INCOME_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public int CUSTOMER_INCOME_KEY { get; set; }

        public virtual CustomerIncome CustomerIncome { get; set; }

        public virtual Loan Loan { get; set; }
    }
}
