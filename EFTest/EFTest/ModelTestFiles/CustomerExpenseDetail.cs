namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerExpenseDetail")]
    public partial class CustomerExpenseDetail
    {
        [Key]
        public int CUSTOMER_EXPENSE_DETAIL_KEY { get; set; }

        public int CUSTOMER_EXPENSE_KEY { get; set; }

        public int EXPENSE_TYPE_KEY { get; set; }

        [Column(TypeName = "money")]
        public decimal? AMOUNT { get; set; }

        public virtual CustomerExpense CustomerExpense { get; set; }

        public virtual ExpenseType ExpenseType { get; set; }
    }
}
