using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallQueueType
    {
        public WebCallQueueType()
        {
            WebCallQueue = new HashSet<WebCallQueue>();
            WebCallWorkQueue = new HashSet<WebCallWorkQueue>();
        }

        public int WebCallQueueTypeKey { get; set; }
        public string Description { get; set; }
        public bool? KeepOpen { get; set; }
        public int? PopPriority { get; set; }
        public DateTime? DateEntered { get; set; }

        public virtual ICollection<WebCallQueue> WebCallQueue { get; set; }
        public virtual ICollection<WebCallWorkQueue> WebCallWorkQueue { get; set; }
    }
}
