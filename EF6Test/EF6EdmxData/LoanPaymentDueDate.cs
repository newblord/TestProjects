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
    
    public partial class LoanPaymentDueDate
    {
        public int LOAN_PAYMENT_DUE_DATE_KEY { get; set; }
        public int LOAN_PAYMENT_KEY { get; set; }
        public System.DateTime ORIG_DUE_DATE { get; set; }
        public System.DateTime ADJUSTED_DUE_DATE { get; set; }
        public decimal PAST_DUE_AMT { get; set; }
        public decimal COLLECTIONS_AMT { get; set; }
        public decimal PENDING_ACH_AMT { get; set; }
    
        public virtual LoanPayment LoanPayment { get; set; }
    }
}
