using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DirtyDataGroup
    {
        public DirtyDataGroup()
        {
            DirtyDataJob = new HashSet<DirtyDataJob>();
        }

        public int DirtyDataGroupKey { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<DirtyDataJob> DirtyDataJob { get; set; }
    }
}
