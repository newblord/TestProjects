using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallRarreason
    {
        public WebCallRarreason()
        {
            WebCallQueue = new HashSet<WebCallQueue>();
            WebCallRarrcategoryReason = new HashSet<WebCallRarrcategoryReason>();
        }

        public int WebCallRarrReasonKey { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<WebCallQueue> WebCallQueue { get; set; }
        public virtual ICollection<WebCallRarrcategoryReason> WebCallRarrcategoryReason { get; set; }
    }
}
