using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallIntraChatSession
    {
        public WebCallIntraChatSession()
        {
            WebCallIntraChatMessage = new HashSet<WebCallIntraChatMessage>();
        }

        public int WebCallIntraChatSessionKey { get; set; }
        public string FromUserId { get; set; }
        public string ToUserId { get; set; }
        public bool FromUserLoggedIn { get; set; }
        public bool ToUserLoggedIn { get; set; }
        public DateTime? FromUserLogOutDate { get; set; }
        public DateTime? ToUserLogOutDate { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual ICollection<WebCallIntraChatMessage> WebCallIntraChatMessage { get; set; }
    }
}
