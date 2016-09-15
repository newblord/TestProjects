namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanPaymentMPay")]
    public partial class LoanPaymentMPay
    {
        [Key]
        public int LOAN_PAYMENT_MPAY_KEY { get; set; }

        public int LOAN_PAYMENT_KEY { get; set; }

        public bool ADD_TO_COLL { get; set; }

        public bool REM_FROM_COLL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PENDING_SCHED_ACH_AMT { get; set; }

        public bool IS_CO_EARLY_PAYOFF_REBATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal COLL_FEE_PAST_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LEGAL_FEE_PAST_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_FEE_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TRANS_FEE_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INTEREST_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINC_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAYMENT_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAYMENT_PAST_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CAB_COLL_FEE_PAST_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CAB_INTEREST_DUE_PAID { get; set; }

        public bool IS_SCHEDULED_PAYMENT { get; set; }

        public bool IS_DAY_AFTER_DUE_PAYMENT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NSF_FEE_PAST_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INSURANCE_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal DUE_DATE_PAYMENT_QUEUE_PAID { get; set; }

        public virtual LoanPayment LoanPayment { get; set; }
    }
}
