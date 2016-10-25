using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallChatMessage
    {
        public Guid WebUniqueIdentifierKey { get; set; }
        public Guid WebCallChatSessionKey { get; set; }
        public string Message { get; set; }
        public DateTime DateSent { get; set; }

        public virtual WebCallChatSession WebCallChatSessionKeyNavigation { get; set; }
    }
}
