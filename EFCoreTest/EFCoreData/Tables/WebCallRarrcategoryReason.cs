using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallRarrcategoryReason
    {
        public int WebCallRarrCategoryReasonKey { get; set; }
        public int WebCallCategoryReasonKey { get; set; }
        public int WebCallRarrReasonKey { get; set; }

        public virtual WebCallCategory WebCallCategoryReasonKeyNavigation { get; set; }
        public virtual WebCallRarreason WebCallRarrReasonKeyNavigation { get; set; }
    }
}
