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
    
    public partial class WebDialerUploadHistory
    {
        public int WEB_DIALER_UPLOAD_HISTORY_KEY { get; set; }
        public int WEB_CALL_QUEUE_KEY { get; set; }
        public Nullable<System.DateTime> WORK_ITEM_DATE_ENTERED { get; set; }
        public int PRIORITY { get; set; }
        public string CATEGORY { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string CELL_PHONE { get; set; }
        public string HOME_PHONE { get; set; }
        public string WORK_PHONE { get; set; }
        public string UPLOAD_OPERATION { get; set; }
        public System.DateTime UPLOAD_DATE { get; set; }
    
        public virtual WebCallQueue WebCallQueue { get; set; }
    }
}
