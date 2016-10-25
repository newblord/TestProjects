using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallFaqattachment
    {
        public int WebCallFaqAttachmentKey { get; set; }
        public int WebCallFaqKey { get; set; }
        public byte[] Attachment { get; set; }
        public string AttachmentName { get; set; }

        public virtual WebCallFaq WebCallFaqKeyNavigation { get; set; }
    }
}
