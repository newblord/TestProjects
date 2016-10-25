namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiscountMasterLoanProduct")]
    public partial class DiscountMasterLoanProduct
    {
        [Key]
        public int DISCOUNT_MASTER_LOAN_PRODUCT_KEY { get; set; }

        public int DISCOUNT_MASTER_KEY { get; set; }

        public int LOAN_PRODUCT_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public virtual DiscountMaster DiscountMaster { get; set; }

        public virtual LoanProduct LoanProduct { get; set; }
    }
}
