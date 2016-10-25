using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallLoggingCategoryLog
    {
        public int WebCallLoggingCategoryLogKey { get; set; }
        public int WebCallLoggingCategoryKey { get; set; }
        public int WebCallLoggingLogKey { get; set; }

        public virtual WebCallLoggingCategory WebCallLoggingCategoryKeyNavigation { get; set; }
        public virtual WebCallLoggingLog WebCallLoggingLogKeyNavigation { get; set; }
    }
}
