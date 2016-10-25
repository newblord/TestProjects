namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanPaymentRescind")]
    public partial class LoanPaymentRescind
    {
        [Key]
        public int LOAN_PAYMENT_RESCIND_KEY { get; set; }

        public int LOAN_PAYMENT_KEY { get; set; }

        public int CASH_ADVANCE_LOAN_PAYMENT_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal RESCIND_AMOUNT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal INTEREST_REBATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CAB_LENDER_INTEREST_REBATE { get; set; }

        public virtual LoanPayment LoanPayment { get; set; }

        public virtual LoanPayment LoanPayment1 { get; set; }
    }
}
