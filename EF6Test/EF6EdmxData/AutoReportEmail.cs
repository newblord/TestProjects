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
    
    public partial class AutoReportEmail
    {
        public int AUTO_REPORT_EMAIL_KEY { get; set; }
        public int AUTO_REPORT_KEY { get; set; }
        public string EMAIL_ADDRESS { get; set; }
    
        public virtual AutoReport AutoReport { get; set; }
    }
}
