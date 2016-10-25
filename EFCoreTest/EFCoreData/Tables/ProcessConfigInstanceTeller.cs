using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ProcessConfigInstanceTeller
    {
        public int ProcessConfigInstanceTellerKey { get; set; }
        public int ProcessConfigInstanceKey { get; set; }
        public string Teller { get; set; }

        public virtual ProcessConfigInstance ProcessConfigInstanceKeyNavigation { get; set; }
        public virtual Tellerid TellerNavigation { get; set; }
    }
}
