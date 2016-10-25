using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallVisitorAlertsAudit
    {
        public int WebCallVisitorAlertAuditId { get; set; }
        public DateTime AuditDate { get; set; }
        public string AuditType { get; set; }
        public int WebCallVisitorAlertId { get; set; }
        public int VisitorId { get; set; }
        public string AlertNote { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool Active { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string LastEditedBy { get; set; }
        public DateTime LastEditDate { get; set; }
    }
}
