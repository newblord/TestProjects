using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallQueueStatus
    {
        public WebCallQueueStatus()
        {
            WebCallQueue = new HashSet<WebCallQueue>();
        }

        public int WebCallQueueStatusKey { get; set; }
        public string Description { get; set; }

        public virtual ICollection<WebCallQueue> WebCallQueue { get; set; }
    }
}
