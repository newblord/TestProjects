using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Ddiachhistory
    {
        public int DdiKey { get; set; }
        public int AchHistoryKey { get; set; }
        public short AchSequenceNumber { get; set; }

        public virtual AchHistory AchHistoryKeyNavigation { get; set; }
        public virtual Ddi DdiKeyNavigation { get; set; }
    }
}
