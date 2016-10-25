using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallBatchCriteria
    {
        public int WebCallBatchTaskCriteriaKey { get; set; }
        public int WebCallBatchTaskKey { get; set; }
        public int CriteriaType { get; set; }
        public int CriteriaValue { get; set; }
        public int? WebCallReasonKey { get; set; }
        public int? WebCallActionKey { get; set; }
        public int? WebCallResult1Key { get; set; }
        public int? WebCallResult2Key { get; set; }
        public int? WebCallRarrKey { get; set; }

        public virtual WebCallBatchTask WebCallBatchTaskKeyNavigation { get; set; }
    }
}
