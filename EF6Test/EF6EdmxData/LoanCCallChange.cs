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
    
    public partial class LoanCCallChange
    {
        public int LOAN_CCALL_CHANGE_KEY { get; set; }
        public int LOAN_KEY { get; set; }
        public short LOCATION { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string ENTERED_BY { get; set; }
        public Nullable<bool> COURTESY_CALL { get; set; }
        public Nullable<bool> EMAIL_STATEMENTS { get; set; }
    
        public virtual Loan Loan { get; set; }
    }
}