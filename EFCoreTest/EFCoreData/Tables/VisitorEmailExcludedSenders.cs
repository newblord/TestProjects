using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class VisitorEmailExcludedSenders
    {
        public int VisitorEmailExcludedSendersKey { get; set; }
        public string EmailUser { get; set; }
        public string EmailDomain { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
    }
}
