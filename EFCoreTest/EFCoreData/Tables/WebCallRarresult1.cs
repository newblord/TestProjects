using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallRarresult1
    {
        public WebCallRarresult1()
        {
            WebCallQueue = new HashSet<WebCallQueue>();
        }

        public int WebCallRarrResult1Key { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<WebCallQueue> WebCallQueue { get; set; }
    }
}
