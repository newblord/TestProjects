namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OpenEndInterest")]
    public partial class OpenEndInterest
    {
        [Key]
        public int OPEN_END_INTEREST_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINC_DUE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal INTEREST_ADDED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime INTEREST_DATE { get; set; }

        public int? OPEN_END_LOAN_STMT_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_BALANCE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CSO_LENDER_INTEREST_ADDED { get; set; }

        public bool IS_ACH_ADJ { get; set; }

        public bool IS_ERR_ADJ { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CAB_FEE_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? COLLECTIONS_AMT { get; set; }

        public bool IS_GRACE_PERIOD_ADJ { get; set; }

        public virtual OpenEndLoanStatement OpenEndLoanStatement { get; set; }
    }
}
