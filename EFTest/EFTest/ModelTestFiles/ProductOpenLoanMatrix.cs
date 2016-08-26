namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductOpenLoanMatrix")]
    public partial class ProductOpenLoanMatrix
    {
        [Key]
        public int PRODUCT_OPEN_LOAN_MATRIX_KEY { get; set; }

        public short LOCATION { get; set; }

        public int LOAN_PRODUCT_KEY_OPEN { get; set; }

        public int LOAN_PRODUCT_KEY_ALLOWED { get; set; }

        public virtual Company Company { get; set; }

        public virtual LoanProduct LoanProduct { get; set; }

        public virtual LoanProduct LoanProduct1 { get; set; }
    }
}
