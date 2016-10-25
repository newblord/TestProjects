using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CapsRun
    {
        public int CapsRunKey { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public byte CapsRunStatusKey { get; set; }
        public int ProcessConfigInstanceKey { get; set; }
        public int PrevCapsRunKey { get; set; }

        public virtual CapsRunStatus CapsRunStatusKeyNavigation { get; set; }
    }
}
