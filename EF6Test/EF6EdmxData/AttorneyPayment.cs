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
    
    public partial class AttorneyPayment
    {
        public int ATTORNEY_PAYMENT_KEY { get; set; }
        public int ATTORNEY_LOAN_KEY { get; set; }
        public Nullable<int> CASHED_CHECK_PAYMENT_KEY { get; set; }
        public Nullable<int> LOAN_PAYMENT_KEY { get; set; }
        public short ATTORNEY_KEY { get; set; }
        public Nullable<System.DateTime> SENT_TO_ATTORNEY { get; set; }
        public decimal AMT_DUE_ATTORNEY { get; set; }
        public bool REVERSED { get; set; }
        public Nullable<System.DateTime> REVERSED_DATE { get; set; }
    
        public virtual Attorney Attorney { get; set; }
        public virtual AttorneyLoan AttorneyLoan { get; set; }
        public virtual CashedCheckPayment CashedCheckPayment { get; set; }
        public virtual LoanPayment LoanPayment { get; set; }
    }
}