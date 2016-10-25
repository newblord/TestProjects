using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallLoggingLog
    {
        public WebCallLoggingLog()
        {
            WebCallLoggingCategoryLog = new HashSet<WebCallLoggingCategoryLog>();
        }

        public int WebCallLoggingLogKey { get; set; }
        public int? WebCallLoggingLogEventKey { get; set; }
        public int Priority { get; set; }
        public string Severity { get; set; }
        public string Title { get; set; }
        public DateTime TimeStamp { get; set; }
        public string MachineName { get; set; }
        public string AppDomainName { get; set; }
        public string WebCallLoggingLogKeyProcessKey { get; set; }
        public string ProcessName { get; set; }
        public string ThreadName { get; set; }
        public string Win32ThreadId { get; set; }
        public string Message { get; set; }
        public string FormattedMessage { get; set; }

        public virtual ICollection<WebCallLoggingCategoryLog> WebCallLoggingCategoryLog { get; set; }
    }
}
