using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallQueueAudit
    {
        public int WebCallQueueAuditKey { get; set; }
        public DateTime AuditDate { get; set; }
        public string User { get; set; }
        public int WebCallQueueKey { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
