using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CheckAgainHistory
    {
        public int CheckagainhistoryKey { get; set; }
        public int CheckagainKey { get; set; }
        public string Status { get; set; }
        public DateTime DateEntered { get; set; }

        public virtual CheckAgain CheckagainKeyNavigation { get; set; }
    }
}
