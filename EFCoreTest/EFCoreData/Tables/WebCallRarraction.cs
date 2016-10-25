using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallRarraction
    {
        public WebCallRarraction()
        {
            WebCallQueue = new HashSet<WebCallQueue>();
        }

        public int WebCallRarrActionKey { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<WebCallQueue> WebCallQueue { get; set; }
    }
}
