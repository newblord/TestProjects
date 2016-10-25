using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DirtyDataJob
    {
        public DirtyDataJob()
        {
            DirtyDataJobRun = new HashSet<DirtyDataJobRun>();
        }

        public int DirtyDataJobKey { get; set; }
        public int GroupKey { get; set; }
        public string JobName { get; set; }
        public string Description { get; set; }
        public string StoredProcName { get; set; }
        public bool IsEnabled { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }

        public virtual ICollection<DirtyDataJobRun> DirtyDataJobRun { get; set; }
        public virtual DirtyDataGroup GroupKeyNavigation { get; set; }
    }
}
