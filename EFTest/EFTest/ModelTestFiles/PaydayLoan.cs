namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaydayLoan")]
    public partial class PaydayLoan
    {
        [Key]
        public int PAYDAY_LOAN_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        [Required]
        [StringLength(10)]
        public string CHECK_NO { get; set; }

        public bool? STARTUP_CHECK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SPLIT_2ND_RATE_PCT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? SPLIT_AMOUNT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? SPLIT_PRV_OPEN_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? SPLIT_1ST_FEE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? SPLIT_2ND_FEE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        [StringLength(10)]
        public string DISPLAY_CHECK_NO { get; set; }

        [Required]
        [StringLength(1)]
        public string DEPOSIT_METHOD { get; set; }

        public bool IS_PREPAY { get; set; }

        public int AGREEMENT_NUMBER { get; set; }

        public int? DUEDATE_CHANGE_KEY { get; set; }

        public bool IS_EXPRESS { get; set; }

        public virtual Loan Loan { get; set; }
    }
}
