using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class UddreportDetail
    {
        public int UddReportDetailKey { get; set; }
        public int UddReportKey { get; set; }
        public int? AchHistoryKey { get; set; }
        public DateTime OriginalProcessingDate { get; set; }
        public string ReturnDescription { get; set; }
        public string ReturnCode { get; set; }
        public string TransCode { get; set; }
        public string Reference { get; set; }
        public string CoreReference { get; set; }
        public decimal Amount { get; set; }
        public bool IsProcessed { get; set; }

        public virtual AchHistory AchHistoryKeyNavigation { get; set; }
        public virtual Uddreport UddReportKeyNavigation { get; set; }
    }
}
