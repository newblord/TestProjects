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
    
    public partial class UDDReportDetail
    {
        public int UDD_REPORT_DETAIL_KEY { get; set; }
        public int UDD_REPORT_KEY { get; set; }
        public Nullable<int> ACH_HISTORY_KEY { get; set; }
        public System.DateTime ORIGINAL_PROCESSING_DATE { get; set; }
        public string RETURN_DESCRIPTION { get; set; }
        public string RETURN_CODE { get; set; }
        public string TRANS_CODE { get; set; }
        public string REFERENCE { get; set; }
        public string CORE_REFERENCE { get; set; }
        public decimal AMOUNT { get; set; }
        public bool IS_PROCESSED { get; set; }
    
        public virtual ACH_History ACH_History { get; set; }
        public virtual UDDReport UDDReport { get; set; }
    }
}