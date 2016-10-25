using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebLeadPostData
    {
        public int WebLeadKey { get; set; }
        public string FormData { get; set; }
        public string ResponseData { get; set; }
        public string Result { get; set; }
        public string Info { get; set; }
        public string Error { get; set; }
        public string Url { get; set; }
        public decimal? Price { get; set; }
        public int WebLeadPostedDataKey { get; set; }
        public DateTime? DateEntered { get; set; }
        public short? ProcessTime { get; set; }
        public short? ScoringTime { get; set; }
        public string AppServerName { get; set; }
    }
}
