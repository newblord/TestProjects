using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebDialerUploadHistory
    {
        public int WebDialerUploadHistoryKey { get; set; }
        public int WebCallQueueKey { get; set; }
        public DateTime? WorkItemDateEntered { get; set; }
        public int Priority { get; set; }
        public string Category { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CellPhone { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string UploadOperation { get; set; }
        public DateTime UploadDate { get; set; }

        public virtual WebCallQueue WebCallQueueKeyNavigation { get; set; }
    }
}
