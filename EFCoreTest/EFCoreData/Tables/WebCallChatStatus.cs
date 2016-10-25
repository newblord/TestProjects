using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallChatStatus
    {
        public int WebCallChatStatusKey { get; set; }
        public Guid WebCallChatSessionKey { get; set; }
        public string Message { get; set; }
        public int StatusType { get; set; }
        public DateTime StatusDate { get; set; }
        public int WebCallChatUserKey { get; set; }

        public virtual WebCallChatSession WebCallChatSessionKeyNavigation { get; set; }
        public virtual WebCallChatUser WebCallChatUserKeyNavigation { get; set; }
    }
}
