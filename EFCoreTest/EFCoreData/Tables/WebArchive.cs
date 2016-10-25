using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebArchive
    {
        public WebArchive()
        {
            WebCallRecordingArchive = new HashSet<WebCallRecordingArchive>();
        }

        public int WebArchiveKey { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public DateTime DateEntered { get; set; }

        public virtual ICollection<WebCallRecordingArchive> WebCallRecordingArchive { get; set; }
    }
}
