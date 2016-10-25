using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AutoReportEmail
    {
        public int AutoReportEmailKey { get; set; }
        public int AutoReportKey { get; set; }
        public string EmailAddress { get; set; }

        public virtual AutoReport AutoReportKeyNavigation { get; set; }
    }
}
