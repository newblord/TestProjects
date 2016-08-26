namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanPaymentOpenEndRefund")]
    public partial class LoanPaymentOpenEndRefund
    {
        [Key]
        public int LOAN_PAYMENT_OPEN_END_REFUND_KEY { get; set; }

        public int ACCOUNTING_LOAN_PAYMENT_KEY { get; set; }

        public int LOAN_PAYMENT_REFUND_XREF_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_TRANS_FEE_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_LIEN_FEE_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_ACTIVITY_FEE_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_COLL_FEE_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_INTEREST_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_PRINC_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_CSO_LENDER_COLL_FEE_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_CSO_LENDER_INTEREST_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_TRANS_FEE_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_LIEN_FEE_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_ACTIVITY_FEE_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_INTEREST_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_PRINC_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_CSO_LENDER_INTEREST_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_TRANS_FEE_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_LIEN_FEE_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_ACTIVITY_FEE_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_INTEREST_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_PRINC_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_CSO_LENDER_INTEREST_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_TRANS_FEE_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_LIEN_FEE_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_ACTIVITY_FEE_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_INTEREST_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_PRINC_REFUNDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_CSO_LENDER_INTEREST_REFUNDED { get; set; }

        public virtual LoanPaymentRefundXRef LoanPaymentRefundXRef { get; set; }
    }
}
