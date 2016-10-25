using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AutoReportTab
    {
        public int AutoReportTabKey { get; set; }
        public int AutoReportKey { get; set; }
        public byte ResultNum { get; set; }
        public string TabName { get; set; }

        public virtual AutoReport AutoReportKeyNavigation { get; set; }
    }
}
