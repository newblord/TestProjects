using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallCsrreportColumnRarr
    {
        public int WebCallCsrreportColumnRarrKey { get; set; }
        public int WebCallCsrreportColumnsKey { get; set; }
        public int WebCallRarrKey { get; set; }

        public virtual WebCallCsrreportColumn WebCallCsrreportColumnsKeyNavigation { get; set; }
    }
}
