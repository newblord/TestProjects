using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CreditRptPrint
    {
        public int CrpKey { get; set; }
        public int CreditRptKey { get; set; }
        public int? LineOrder { get; set; }
        public int? PrintOrder { get; set; }
        public string ReportLine { get; set; }
    }
}
