using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallChatSession
    {
        public WebCallChatSession()
        {
            WebCallChatMessage = new HashSet<WebCallChatMessage>();
            WebCallChatStatus = new HashSet<WebCallChatStatus>();
        }

        public Guid WebCallChatSessionKey { get; set; }
        public int WebCallQueueKey { get; set; }
        public string Teller { get; set; }
        public int WebCallChatUserKey { get; set; }
        public DateTime? DateRequested { get; set; }
        public DateTime? DateAccepted { get; set; }
        public DateTime? DateEnded { get; set; }
        public int WebCallChatTopicsKey { get; set; }

        public virtual ICollection<WebCallChatMessage> WebCallChatMessage { get; set; }
        public virtual ICollection<WebCallChatStatus> WebCallChatStatus { get; set; }
        public virtual WebCallQueue WebCallQueueKeyNavigation { get; set; }
    }
}
