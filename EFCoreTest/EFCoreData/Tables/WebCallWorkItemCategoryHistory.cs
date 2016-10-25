using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallWorkItemCategoryHistory
    {
        public int WebCallWorkItemCategoryHistoryKey { get; set; }
        public int WebCallQueueKey { get; set; }
        public int WebCallCategoryKey { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual WebCallCategory WebCallCategoryKeyNavigation { get; set; }
    }
}
