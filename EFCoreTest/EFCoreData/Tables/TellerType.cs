using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class TellerType
    {
        public TellerType()
        {
            Tellerid = new HashSet<Tellerid>();
        }

        public byte TellerType1 { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Tellerid> Tellerid { get; set; }
    }
}
