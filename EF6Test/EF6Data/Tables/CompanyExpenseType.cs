namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyExpenseType")]
    public partial class CompanyExpenseType
    {
        [Key]
        public int COMPANY_EXPENSE_TYPE_KEY { get; set; }

        public short LOCATION { get; set; }

        public int EXPENSE_TYPE_KEY { get; set; }

        public virtual Company Company { get; set; }

        public virtual ExpenseType ExpenseType { get; set; }
    }
}
