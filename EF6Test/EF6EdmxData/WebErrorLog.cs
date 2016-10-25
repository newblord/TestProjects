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
    
    public partial class WebErrorLog
    {
        public int WEB_ERROR_LOG_KEY { get; set; }
        public Nullable<int> VISITOR_KEY { get; set; }
        public Nullable<int> APPLICATION_KEY { get; set; }
        public Nullable<int> CUSTOMER_KEY { get; set; }
        public Nullable<int> LOAN_KEY { get; set; }
        public string CURRENT_PAGE { get; set; }
        public string EXCEPTION_TYPE { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string ERROR_MSG { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Loan Loan { get; set; }
        public virtual LoanApplication LoanApplication { get; set; }
        public virtual Visitor Visitor { get; set; }
    }
}
