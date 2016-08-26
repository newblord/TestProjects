namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TitleLoanApproval")]
    public partial class TitleLoanApproval
    {
        [Key]
        public int TITLELOAN_APPROVAL_KEY { get; set; }

        public int TITLELOAN_KEY { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TLA_WHOLESALE_PCT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TLA_CHK_ACCT_PCT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TLA_CCARD_PCT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TLA_EMP_SINCE_PCT { get; set; }

        public int TLA_EMP_SINCE_MON { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TLA_BASE_PCT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TLA_BASE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TLA_NET_INC_AMT { get; set; }

        public bool TLA_NET_INC_USED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TLA_NET_INC_PCT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TLA_WHOLE_MIN_PCT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TLA_WHOLE_MIN_AMT { get; set; }

        public bool TLA_WHOLE_MIN_USED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TLA_MAX_LOAN_AMT { get; set; }

        public bool TLA_MAX_LOAN_USED { get; set; }

        public bool TLA_NET_INC_LIMIT { get; set; }

        public bool TLA_FULL_INS_1000 { get; set; }

        public bool TLA_PAY_VER_500 { get; set; }

        public bool TLA_EMP_3_MON_500 { get; set; }

        public bool TLA_MIN_LOAN_150 { get; set; }

        public bool TLA_MAX_NET_INC_25 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public short ENTERED_LOCATION { get; set; }

        public bool? TLA_2ND_LIEN_INCR { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TLA_2ND_LIEN_INCR_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? APPROVAL_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? MGR_OVERRIDE_AMT { get; set; }

        [StringLength(3)]
        public string MGR_OVERRIDE_INITS { get; set; }

        public int? LOAN_KEY { get; set; }

        public int SCORE_VALUE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal SCORE_AMOUNT { get; set; }

        public virtual TitleLoan TitleLoan { get; set; }
    }
}
