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
    
    public partial class WebCallCSRReportColumnRARR
    {
        public int Web_Call_CSRReport_ColumnRARR_Key { get; set; }
        public int Web_Call_CSRReport_Columns_Key { get; set; }
        public int Web_Call_RARR_Key { get; set; }
    
        public virtual WebCallCSRReportColumn WebCallCSRReportColumn { get; set; }
    }
}