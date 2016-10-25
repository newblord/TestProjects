using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CollectionAgencyPct
    {
        public int CollectionAgencyPctKey { get; set; }
        public int CollectionAgencyKey { get; set; }
        public byte AssignmentNumber { get; set; }
        public decimal Pct { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsActive { get; set; }

        public virtual CollectionAgency CollectionAgencyKeyNavigation { get; set; }
    }
}
