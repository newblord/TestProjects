using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallChatUser
    {
        public WebCallChatUser()
        {
            WebCallChatStatus = new HashSet<WebCallChatStatus>();
        }

        public int WebCallChatUserKey { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<WebCallChatStatus> WebCallChatStatus { get; set; }
    }
}
