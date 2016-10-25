using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Smsresponse
    {
        public int SmsResponseKey { get; set; }
        public int? SmsOutboundKey { get; set; }
        public string Response { get; set; }
        public DateTime? SentDate { get; set; }
        public string SentUsing { get; set; }
        public bool? Sent { get; set; }

        public virtual Smsoutbound SmsOutboundKeyNavigation { get; set; }
    }
}
