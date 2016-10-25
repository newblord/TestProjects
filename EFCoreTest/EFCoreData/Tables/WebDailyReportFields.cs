using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebDailyReportFields
    {
        public int WebDailyReportFieldsKey { get; set; }
        public string FieldDescription { get; set; }
        public string GroupName { get; set; }
        public int GroupSortPriority { get; set; }
        public int FieldSortPriority { get; set; }
        public bool Disabled { get; set; }
        public bool? AllowRange { get; set; }
    }
}
