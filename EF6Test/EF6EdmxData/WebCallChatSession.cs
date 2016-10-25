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
    
    public partial class WebCallChatSession
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebCallChatSession()
        {
            this.WebCallChatMessages = new HashSet<WebCallChatMessage>();
            this.WebCallChatStatus = new HashSet<WebCallChatStatu>();
        }
    
        public System.Guid WEB_CALL_CHAT_SESSION_KEY { get; set; }
        public int WEB_CALL_QUEUE_KEY { get; set; }
        public string TELLER { get; set; }
        public int WEB_CALL_CHAT_USER_KEY { get; set; }
        public Nullable<System.DateTime> DATE_REQUESTED { get; set; }
        public Nullable<System.DateTime> DATE_ACCEPTED { get; set; }
        public Nullable<System.DateTime> DATE_ENDED { get; set; }
        public int WEB_CALL_CHAT_TOPICS_KEY { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallChatMessage> WebCallChatMessages { get; set; }
        public virtual WebCallQueue WebCallQueue { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallChatStatu> WebCallChatStatus { get; set; }
    }
}
