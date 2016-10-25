using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ProcessConfigDetail
    {
        public int ProcessConfigDetailKey { get; set; }
        public int ProcessConfigInstanceKey { get; set; }
        public string ConfigName { get; set; }
        public string ConfigValue { get; set; }

        public virtual ProcessConfigInstance ProcessConfigInstanceKeyNavigation { get; set; }
    }
}
