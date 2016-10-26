﻿using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallRarresult2
    {
        public WebCallRarresult2()
        {
            WebCallQueue = new HashSet<WebCallQueue>();
        }

        public int WebCallRarrResult2Key { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<WebCallQueue> WebCallQueue { get; set; }
    }
}