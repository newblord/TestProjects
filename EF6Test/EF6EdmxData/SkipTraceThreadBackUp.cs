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
    
    public partial class SkipTraceThreadBackUp
    {
        public int SKIP_TRACE_THREAD_KEY { get; set; }
        public int SKIP_TRACE_CONFIG_KEY { get; set; }
        public Nullable<int> RISREPT_KEY { get; set; }
        public Nullable<int> CUSTOMER_KEY { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public System.DateTime DATE_ACTIVE { get; set; }
        public bool IF_NO_ADDRESS { get; set; }
        public bool IF_NO_CELL_PHONE { get; set; }
        public bool IF_NO_HOME_PHONE { get; set; }
        public bool IF_NO_WORK_PHONE { get; set; }
        public Nullable<System.DateTime> DATE_LAST_CONTACT { get; set; }
        public byte PASS_COUNTER { get; set; }
        public byte STEP_NUMBER { get; set; }
        public Nullable<int> SKIP_TRACE_STEP_KEY { get; set; }
        public byte VENDOR_NUMBER { get; set; }
        public Nullable<int> SKIP_TRACE_VENDOR_KEY { get; set; }
        public string TRACE_STATUS { get; set; }
    }
}