using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebBlobType
    {
        public WebBlobType()
        {
            WebBlob = new HashSet<WebBlob>();
        }

        public short WebBlobTypeKey { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<WebBlob> WebBlob { get; set; }
    }
}
