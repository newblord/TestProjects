using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ProcessConfigInstanceGroup
    {
        public int ProcessConfigInstanceGroupKey { get; set; }
        public int ProcessConfigInstanceKey { get; set; }
        public int SecuritygroupKey { get; set; }

        public virtual ProcessConfigInstance ProcessConfigInstanceKeyNavigation { get; set; }
        public virtual SecurityGroup SecuritygroupKeyNavigation { get; set; }
    }
}
