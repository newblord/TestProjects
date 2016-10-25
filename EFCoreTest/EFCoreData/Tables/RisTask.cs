using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class RisTask
    {
        public RisTask()
        {
            Ris = new HashSet<Ris>();
        }

        public string Task { get; set; }
        public string Desc { get; set; }
        public string Short { get; set; }
        public int RisTaskId { get; set; }
        public bool Displayed { get; set; }

        public virtual ICollection<Ris> Ris { get; set; }
    }
}
