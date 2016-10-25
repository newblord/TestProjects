using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Achreason
    {
        public Achreason()
        {
            AchHistory = new HashSet<AchHistory>();
            AchprocessingQueue = new HashSet<AchprocessingQueue>();
            Achqueue = new HashSet<Achqueue>();
        }

        public short Code { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public virtual ICollection<AchHistory> AchHistory { get; set; }
        public virtual ICollection<AchprocessingQueue> AchprocessingQueue { get; set; }
        public virtual ICollection<Achqueue> Achqueue { get; set; }
    }
}
