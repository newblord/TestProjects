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
    
    public partial class OpenEndInterest
    {
        public int OPEN_END_INTEREST_KEY { get; set; }
        public int LOAN_KEY { get; set; }
        public decimal PRINC_DUE { get; set; }
        public decimal INTEREST_ADDED { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public System.DateTime INTEREST_DATE { get; set; }
        public Nullable<int> OPEN_END_LOAN_STMT_KEY { get; set; }
        public decimal LOAN_BALANCE { get; set; }
        public decimal CSO_LENDER_INTEREST_ADDED { get; set; }
        public bool IS_ACH_ADJ { get; set; }
        public bool IS_ERR_ADJ { get; set; }
        public decimal CAB_FEE_BALANCE { get; set; }
        public Nullable<decimal> COLLECTIONS_AMT { get; set; }
        public bool IS_GRACE_PERIOD_ADJ { get; set; }
    
        public virtual OpenEndLoanStatement OpenEndLoanStatement { get; set; }
    }
}
