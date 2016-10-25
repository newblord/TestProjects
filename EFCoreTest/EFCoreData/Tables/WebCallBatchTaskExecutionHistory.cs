using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallBatchTaskExecutionHistory
    {
        public int WebCallBatchTaskExecutionKey { get; set; }
        public int WebCallBatchTaskKey { get; set; }
        public string CriteriaText { get; set; }
        public string ActionText { get; set; }
        public string TargetWorkItemIds { get; set; }
        public DateTime RunDate { get; set; }
        public string RunBy { get; set; }
    }
}
