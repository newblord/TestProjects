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
    
    public partial class LoanProductConfigLoanStat
    {
        public int LOAN_PRODUCT_CONFIG_LOAN_STATS_KEY { get; set; }
        public int LOAN_PRODUCT_CONFIG_KEY { get; set; }
        public short LOCATION { get; set; }
        public int LOANS_COUNT { get; set; }
        public int OPEN_LOANS_COUNT { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string ENTERED_BY { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual LoanProductConfig LoanProductConfig { get; set; }
    }
}
