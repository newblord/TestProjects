using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallBatchAction
    {
        public int WebCallBatchTaskActionKey { get; set; }
        public int WebCallBatchTaskKey { get; set; }
        public int ActionType { get; set; }
        public int? WebCallReasonKey { get; set; }
        public int? WebCallActionKey { get; set; }
        public int? WebCallResult1Key { get; set; }
        public int? WebCallResult2Key { get; set; }
        public int? WebCallRarrKey { get; set; }
        public int? WebCallCategoryKey { get; set; }

        public virtual WebCallBatchTask WebCallBatchTaskKeyNavigation { get; set; }
    }
}
