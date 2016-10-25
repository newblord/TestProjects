namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanPaymentMPayRefund")]
    public partial class LoanPaymentMPayRefund
    {
        [Key]
        public int LOAN_PAYMENT_MPAY_REFUND_KEY { get; set; }

        public int ACCOUNTING_LOAN_PAYMENT_KEY { get; set; }

        public int LOAN_PAYMENT_REFUND_XREF_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal COLL_FEE_PAST_DUE_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LEGAL_FEE_PAST_DUE_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_FEE_DUE_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TRANS_FEE_DUE_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INTEREST_DUE_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINC_DUE_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CAB_COLL_FEE_PAST_DUE_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CAB_INTEREST_DUE_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NSF_FEE_PAST_DUE_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INSURANCE_DUE_REFUNDED { get; set; }

        public virtual LoanPaymentRefundXRef LoanPaymentRefundXRef { get; set; }
    }
}
