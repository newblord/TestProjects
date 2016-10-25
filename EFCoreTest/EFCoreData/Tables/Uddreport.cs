using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Uddreport
    {
        public Uddreport()
        {
            UddreportDetail = new HashSet<UddreportDetail>();
        }

        public int UddReportKey { get; set; }
        public int AchRecvKey { get; set; }
        public DateTime UddProcessingDate { get; set; }
        public int AdviceNumber { get; set; }
        public string ReportType { get; set; }
        public DateTime EnteredDate { get; set; }
        public string FileName { get; set; }

        public virtual ICollection<UddreportDetail> UddreportDetail { get; set; }
        public virtual AchRecv AchRecvKeyNavigation { get; set; }
    }
}
