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
    
    public partial class SignatureLoanApproval
    {
        public int SIGNATURE_LOAN_APPROVAL_KEY { get; set; }
        public int LOAN_KEY { get; set; }
        public int CUSTOMER_KEY { get; set; }
        public decimal GROSS_INCOME_AMT { get; set; }
        public decimal NET_INCOME_AMT { get; set; }
        public decimal OPEN_LOANS_PRINC_AMT { get; set; }
        public decimal APPROVAL_BASE_INCOME_AMT { get; set; }
        public decimal APPROVAL_SUCCESSFUL_AMT { get; set; }
        public decimal APPROVAL_BASE_AMT { get; set; }
        public decimal MGR_OVERRIDE_AMT { get; set; }
        public string MGR_OVERRIDE_INITS { get; set; }
        public decimal PREV_PRINC_OVERRIDE_AMT { get; set; }
        public decimal APPROVAL_AMT { get; set; }
        public short SCORED_INCREMENT_AMOUNT { get; set; }
        public Nullable<short> SCORED_INCREMENT_NUM { get; set; }
    
        public virtual Loan Loan { get; set; }
    }
}
