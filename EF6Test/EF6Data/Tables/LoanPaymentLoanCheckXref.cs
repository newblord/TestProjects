namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanPaymentLoanCheckXref")]
    public partial class LoanPaymentLoanCheckXref
    {
        [Key]
        public int LP_LC_XREF_KEY { get; set; }

        public int LOAN_PAYMENT_KEY { get; set; }

        public int LOAN_CHECK_KEY { get; set; }

        public virtual LoanCheck LoanCheck { get; set; }
    }
}
