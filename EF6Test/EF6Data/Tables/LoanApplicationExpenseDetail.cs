namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanApplicationExpenseDetail")]
    public partial class LoanApplicationExpenseDetail
    {
        [Key]
        public int LOAN_APPLICATION_EXPENSE_DETAIL_KEY { get; set; }

        public int LOAN_APPLICATION_EXPENSE_KEY { get; set; }

        public int EXPENSE_TYPE_KEY { get; set; }

        [Column(TypeName = "money")]
        public decimal? AMOUNT { get; set; }

        public virtual ExpenseType ExpenseType { get; set; }

        public virtual LoanApplicationExpense LoanApplicationExpense { get; set; }
    }
}
