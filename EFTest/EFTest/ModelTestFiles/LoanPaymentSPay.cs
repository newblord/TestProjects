namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanPaymentSPay")]
    public partial class LoanPaymentSPay
    {
        [Key]
        public int LOAN_PAYMENT_SPAY_KEY { get; set; }

        public int LOAN_PAYMENT_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal COLL_FEE_DUE_PAID_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LEGAL_FEE_DUE_PAID_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_FEE_DUE_PAID_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INTEREST_DUE_PAID_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CAB_INTEREST_DUE_PAID_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINC_DUE_PAID_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CAB_LENDER_COLL_FEE_PAST_DUE_PAID_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NSF_FEE_DUE_PAID_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TRANS_FEE_DUE_PAID_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PENDING_SCHED_ACH_AMT { get; set; }

        public virtual LoanPayment LoanPayment { get; set; }
    }
}
