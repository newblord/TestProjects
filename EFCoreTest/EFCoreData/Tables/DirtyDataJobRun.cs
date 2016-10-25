using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DirtyDataJobRun
    {
        public int DirtyDataJobRunKey { get; set; }
        public int JobKey { get; set; }
        public DateTime DateEntered { get; set; }
        public int RecordCount { get; set; }
        public bool IsError { get; set; }
        public string ErrorMessage { get; set; }

        public virtual DirtyDataJob JobKeyNavigation { get; set; }
    }
}
