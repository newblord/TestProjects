using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallBatchTask
    {
        public WebCallBatchTask()
        {
            WebCallBatchAction = new HashSet<WebCallBatchAction>();
            WebCallBatchCriteria = new HashSet<WebCallBatchCriteria>();
        }

        public int WebCallBatchTaskKey { get; set; }
        public string TaskName { get; set; }
        public bool Enabled { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public bool AllowScheduling { get; set; }

        public virtual ICollection<WebCallBatchAction> WebCallBatchAction { get; set; }
        public virtual ICollection<WebCallBatchCriteria> WebCallBatchCriteria { get; set; }
    }
}
