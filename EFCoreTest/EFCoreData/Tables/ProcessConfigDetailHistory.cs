using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ProcessConfigDetailHistory
    {
        public int ProcessConfigDetailHistKey { get; set; }
        public int ProcessConfigDetailKey { get; set; }
        public int ProcessConfigInstanceKey { get; set; }
        public string ConfigName { get; set; }
        public string ConfigOldValue { get; set; }
        public DateTime DateEntered { get; set; }
        public string ConfigNewValue { get; set; }

        public virtual ProcessConfigInstance ProcessConfigInstanceKeyNavigation { get; set; }
    }
}
