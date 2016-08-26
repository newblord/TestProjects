namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FurtherFinanceExecutionLogDetail")]
    public partial class FurtherFinanceExecutionLogDetail
    {
        [Key]
        public int FURTHER_FINANCE_EXECUTION_LOG_DETAIL_KEY { get; set; }

        public int FURTHER_FINANCE_EXECUTION_LOG_KEY { get; set; }

        public int FURTHER_FINANCE_OUTCOME_KEY { get; set; }

        public int FURTHER_FINANCE_QUERY_KEY { get; set; }

        public int? LOAN_PRODUCT_CONFIG_KEY { get; set; }

        public int? LOAN_PRODUCT_KEY { get; set; }

        [Column(TypeName = "money")]
        public decimal? LOAN_LIMIT { get; set; }

        [Column(TypeName = "money")]
        public decimal? WAGE_LIMIT { get; set; }

        [Column(TypeName = "money")]
        public decimal? DISPOSABLE_LIMIT { get; set; }

        [Column(TypeName = "money")]
        public decimal? FURTHER_FINANCE_AMT { get; set; }

        [StringLength(255)]
        public string FURTHER_FINANCE_AMT_MESSAGE { get; set; }

        public virtual FurtherFinanceExecutionLog FurtherFinanceExecutionLog { get; set; }

        public virtual FurtherFinanceOutcome FurtherFinanceOutcome { get; set; }

        public virtual FurtherFinanceQuery FurtherFinanceQuery { get; set; }

        public virtual LoanProduct LoanProduct { get; set; }

        public virtual LoanProductConfig LoanProductConfig { get; set; }
    }
}
