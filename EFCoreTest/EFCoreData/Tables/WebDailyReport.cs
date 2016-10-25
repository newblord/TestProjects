using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebDailyReport
    {
        public int WebDailyReportKey { get; set; }
        public int WebDailyReportFieldKey { get; set; }
        public long NumericValue { get; set; }
        public DateTime DateReported { get; set; }
        public string State { get; set; }
        public string Msa { get; set; }
        public string Source { get; set; }
    }
}
