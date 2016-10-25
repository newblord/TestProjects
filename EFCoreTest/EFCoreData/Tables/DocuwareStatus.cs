using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DocuwareStatus
    {
        public int DocuwarestatusKey { get; set; }
        public DateTime DocDate { get; set; }
        public int Location { get; set; }
        public string DocType { get; set; }
        public string IgnoreTeller { get; set; }
        public DateTime? IgnoreDate { get; set; }
        public string IgnoreType { get; set; }
        public int? Dwdocid { get; set; }
    }
}
