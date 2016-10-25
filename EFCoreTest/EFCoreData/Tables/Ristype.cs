using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Ristype
    {
        public Ristype()
        {
            Risrept = new HashSet<Risrept>();
        }

        public string Type { get; set; }
        public string Desc { get; set; }
        public string Short { get; set; }
        public int RisTypeId { get; set; }

        public virtual ICollection<Risrept> Risrept { get; set; }
    }
}
