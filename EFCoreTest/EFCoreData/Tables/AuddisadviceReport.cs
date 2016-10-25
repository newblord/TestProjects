using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AuddisadviceReport
    {
        public int AuddisAdviceReportKey { get; set; }
        public string ReportType { get; set; }
        public DateTime ReportGenerationDate { get; set; }
        public string AdviceType { get; set; }
        public string FileName { get; set; }
    }
}
