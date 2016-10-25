using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AutoReport
    {
        public AutoReport()
        {
            AutoReportEmail = new HashSet<AutoReportEmail>();
            AutoReportSchedule = new HashSet<AutoReportSchedule>();
            AutoReportTab = new HashSet<AutoReportTab>();
        }

        public int AutoReportKey { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public string ReportName { get; set; }
        public string Description { get; set; }
        public string Outfile { get; set; }
        public string ReportSql { get; set; }
        public bool RunMon { get; set; }
        public bool RunTue { get; set; }
        public bool RunWed { get; set; }
        public bool RunThu { get; set; }
        public bool RunFri { get; set; }
        public bool RunSat { get; set; }
        public bool RunSun { get; set; }
        public bool RunEom { get; set; }
        public bool RunEoq { get; set; }
        public bool RunEoy { get; set; }
        public byte RunDom { get; set; }
        public bool OutputXls { get; set; }
        public bool OutputPdf { get; set; }
        public string SqlFileLocation { get; set; }
        public bool AttachFileToEmail { get; set; }
        public bool OutputCsv { get; set; }
        public string EmailSubject { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
        public bool? Deleted { get; set; }

        public virtual ICollection<AutoReportEmail> AutoReportEmail { get; set; }
        public virtual ICollection<AutoReportSchedule> AutoReportSchedule { get; set; }
        public virtual ICollection<AutoReportTab> AutoReportTab { get; set; }
    }
}
