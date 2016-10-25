//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF6EdmxData
{
    using System;
    using System.Collections.Generic;
    
    public partial class FurtherFinanceExecutionLogDetail
    {
        public int FURTHER_FINANCE_EXECUTION_LOG_DETAIL_KEY { get; set; }
        public int FURTHER_FINANCE_EXECUTION_LOG_KEY { get; set; }
        public int FURTHER_FINANCE_OUTCOME_KEY { get; set; }
        public int FURTHER_FINANCE_QUERY_KEY { get; set; }
        public Nullable<int> LOAN_PRODUCT_CONFIG_KEY { get; set; }
        public Nullable<int> LOAN_PRODUCT_KEY { get; set; }
        public Nullable<decimal> LOAN_LIMIT { get; set; }
        public Nullable<decimal> WAGE_LIMIT { get; set; }
        public Nullable<decimal> DISPOSABLE_LIMIT { get; set; }
        public Nullable<decimal> FURTHER_FINANCE_AMT { get; set; }
        public string FURTHER_FINANCE_AMT_MESSAGE { get; set; }
    
        public virtual FurtherFinanceExecutionLog FurtherFinanceExecutionLog { get; set; }
        public virtual FurtherFinanceOutcome FurtherFinanceOutcome { get; set; }
        public virtual FurtherFinanceQuery FurtherFinanceQuery { get; set; }
        public virtual LoanProduct LoanProduct { get; set; }
        public virtual LoanProductConfig LoanProductConfig { get; set; }
    }
}
