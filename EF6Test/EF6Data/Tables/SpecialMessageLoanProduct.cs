namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SpecialMessageLoanProduct")]
    public partial class SpecialMessageLoanProduct
    {
        [Key]
        public int SPECIAL_MESSAGE_LOAN_PRODUCT_KEY { get; set; }

        public int SPECIAL_MESSAGE_KEY { get; set; }

        public int LOAN_PRODUCT_KEY { get; set; }

        public virtual LoanProduct LoanProduct { get; set; }

        public virtual SpecialMessage SpecialMessage { get; set; }
    }
}
