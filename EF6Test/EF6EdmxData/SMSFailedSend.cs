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
    
    public partial class SMSFailedSend
    {
        public int SMS_FAILED_SEND_KEY { get; set; }
        public Nullable<int> SMS_OUTBOUND_KEY { get; set; }
        public string RESPONSE { get; set; }
        public Nullable<System.DateTime> SENT_DATE { get; set; }
        public string SENT_USING { get; set; }
        public Nullable<bool> SENT { get; set; }
    
        public virtual SMSOutbound SMSOutbound { get; set; }
    }
}