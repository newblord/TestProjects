using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CapsRunStatus
    {
        public CapsRunStatus()
        {
            CapsRun = new HashSet<CapsRun>();
        }

        public byte CapsRunStatusKey { get; set; }
        public string RunStatusDesc { get; set; }

        public virtual ICollection<CapsRun> CapsRun { get; set; }
    }
}
