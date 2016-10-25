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
    
    public partial class ErrorLog
    {
        public int ErrorLogKey { get; set; }
        public string ErrorMessage { get; set; }
        public string SupportMessage { get; set; }
        public Nullable<int> VISITOR_KEY { get; set; }
        public Nullable<int> CUSTOMER_KEY { get; set; }
        public Nullable<int> APPLICATION_KEY { get; set; }
        public Nullable<int> LOAN_KEY { get; set; }
        public Nullable<int> Severity { get; set; }
        public string Client { get; set; }
        public string Tier { get; set; }
        public string CodeLocation { get; set; }
        public string ExceptionText { get; set; }
        public string StateDump { get; set; }
        public Nullable<int> TransDetail { get; set; }
        public string WebServer { get; set; }
        public string AppServer { get; set; }
        public string UserAgent { get; set; }
        public string Browser { get; set; }
        public System.DateTime DateEntered { get; set; }
        public string CurrentPage { get; set; }
        public string ReferringPage { get; set; }
        public Nullable<bool> SupportRedirect { get; set; }
        public Nullable<System.DateTime> DateEnteredDay { get; set; }
        public Nullable<System.DateTime> DateEnteredHour { get; set; }
        public Nullable<System.DateTime> DateEnteredMinute { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Loan Loan { get; set; }
        public virtual LoanApplication LoanApplication { get; set; }
    }
}
