namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LoanApplicationDiscount
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_APPLICATION_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DISCOUNT_MASTER_KEY { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smallmoney")]
        public decimal AMOUNT_APPLIED { get; set; }

        public virtual DiscountMaster DiscountMaster { get; set; }

        public virtual LoanApplication LoanApplication { get; set; }
    }
}
