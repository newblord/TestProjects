using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebDialerUser
    {
        public int WebDialerUserKey { get; set; }
        public string Teller { get; set; }
        public string DialerUserId { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateEntered { get; set; }

        public virtual WebDialerUser WebDialerUserKeyNavigation { get; set; }
        public virtual WebDialerUser InverseWebDialerUserKeyNavigation { get; set; }
    }
}
