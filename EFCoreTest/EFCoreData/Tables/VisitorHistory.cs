using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class VisitorHistory
    {
        public int VisitorHistoryKey { get; set; }
        public int VisitorKey { get; set; }
        public string IpAddress { get; set; }
        public DateTime DateEntered { get; set; }
        public string PageName { get; set; }
        public string MethodCall { get; set; }
        public string SessionGuid { get; set; }
        public DateTime? DateEnteredWithSeconds { get; set; }
        public long? WebVisitKey { get; set; }

        public virtual Visitor VisitorKeyNavigation { get; set; }
    }
}
