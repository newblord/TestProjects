namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanService")]
    public partial class LoanService
    {
        [Key]
        public int LOAN_SERVICE_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public int SERVICE_DETAIL_KEY { get; set; }

        public decimal SERVICE_COST { get; set; }

        public decimal PRICE { get; set; }

        public decimal MARK_DOWN { get; set; }

        public decimal SALES_TAX { get; set; }

        public decimal DOWN_PAYMENT { get; set; }

        public virtual Loan Loan { get; set; }

        public virtual ServiceDetail ServiceDetail { get; set; }
    }
}
