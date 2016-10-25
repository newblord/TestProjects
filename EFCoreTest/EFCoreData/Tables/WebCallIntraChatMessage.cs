using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallIntraChatMessage
    {
        public int WebCallIntraChatMessageKey { get; set; }
        public int WebCallIntraChatSessionKey { get; set; }
        public string Message { get; set; }
        public string FromUserId { get; set; }
        public string ToUserId { get; set; }
        public DateTime DateSent { get; set; }

        public virtual WebCallIntraChatSession WebCallIntraChatSessionKeyNavigation { get; set; }
    }
}
