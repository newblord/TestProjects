using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DocumentResource
    {
        public DocumentResource()
        {
            CompanyDocumentResource = new HashSet<CompanyDocumentResource>();
        }

        public int DocumentResourceKey { get; set; }
        public string ResourceName { get; set; }
        public byte[] Data { get; set; }
        public short MimeTypeKey { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDatetime { get; set; }
        public DateTime UpdatedDatetime { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

        public virtual ICollection<CompanyDocumentResource> CompanyDocumentResource { get; set; }
        public virtual Tellerid CreatedByNavigation { get; set; }
        public virtual MimeType MimeTypeKeyNavigation { get; set; }
        public virtual Tellerid UpdatedByNavigation { get; set; }
    }
}
