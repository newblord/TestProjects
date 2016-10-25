using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebBlobVisitorEmailXref
    {
        public int WebBlobVisitorEmailXrefKey { get; set; }
        public int WebBlobKey { get; set; }
        public int VisitorEmailKey { get; set; }
        public string Description { get; set; }
        public DateTime DateEntered { get; set; }
        public string AttachmentName { get; set; }

        public virtual VisitorEmail VisitorEmailKeyNavigation { get; set; }
        public virtual WebBlob WebBlobKeyNavigation { get; set; }
    }
}
