using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallRecordingArchive
    {
        public int WebCallRecordingArchiveKey { get; set; }
        public int WebArchiveKey { get; set; }
        public string SessionId { get; set; }
        public string Teller { get; set; }
        public DateTime CallDate { get; set; }
        public DateTime DateEntered { get; set; }

        public virtual WebArchive WebArchiveKeyNavigation { get; set; }
    }
}
