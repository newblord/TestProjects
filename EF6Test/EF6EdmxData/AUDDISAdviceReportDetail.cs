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
    
    public partial class AUDDISAdviceReportDetail
    {
        public int AUDDIS_ADVICE_REPORT_DETAIL_KEY { get; set; }
        public int AUDDIS_ADVICE_REPORT_KEY { get; set; }
        public string AOSN { get; set; }
        public string REASON_CODE { get; set; }
        public string PAYER_SORT_CODE { get; set; }
        public string PAYER_ACCOUNT_NUMBER { get; set; }
        public string NEW_SORT_CODE { get; set; }
        public string NEW_ACCOUNT_NUMBER { get; set; }
        public string LAST_NAME { get; set; }
        public string REFERENCE { get; set; }
        public System.DateTime EFFECTIVE_DATE { get; set; }
        public string RECORD_TYPE { get; set; }
        public bool IS_PROCESSED { get; set; }
    
        public virtual AUDDISAdviceReport AUDDISAdviceReport { get; set; }
    }
}
