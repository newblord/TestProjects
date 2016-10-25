using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class MimeType
    {
        public MimeType()
        {
            DocumentResource = new HashSet<DocumentResource>();
        }

        public short MimeTypeKey { get; set; }
        public string MimeType1 { get; set; }
        public string FileExtension { get; set; }

        public virtual ICollection<DocumentResource> DocumentResource { get; set; }
    }
}
