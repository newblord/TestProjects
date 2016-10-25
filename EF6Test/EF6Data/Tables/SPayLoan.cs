namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SPayLoan")]
    public partial class SPayLoan
    {
        [Key]
        public int SPAY_LOAN_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ANNUAL_RATE_PCT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INTEREST_PAID { get; set; }

        public bool IS_AUTO_ROLL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal COLL_ANNUAL_RATE_PCT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOT_INTEREST { get; set; }

        public bool IS_INTEREST_SUSPENDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal COLL_FEE_DUE_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LEGAL_FEE_DUE_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_FEE_DUE_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INTEREST_DUE_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CAB_INTEREST_DUE_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINC_DUE_BALANCE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DAILY_RATE_PCT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal COLL_DAILY_RATE_PCT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CAB_ANNUAL_RATE_PCT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CAB_DAILY_RATE_PCT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOT_CAB_INTEREST { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CAB_LENDER_COLL_FEE_PAST_DUE_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOT_CAB_LENDER_COLL_FEE { get; set; }

        public bool CHARGE_INTEREST_ON_LOAN_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NSF_FEE_DUE_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal MIN_INTEREST_AMT { get; set; }

        public short MIN_INTEREST_DAYS { get; set; }

        public bool RI_FEE_REQUIRES_BANK_ACCOUNT { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? DAILY_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TRANS_FEE_DUE_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal ROLLOVER_AMORT_PAYMENT_AMT { get; set; }

        public virtual Loan Loan { get; set; }
    }
}
