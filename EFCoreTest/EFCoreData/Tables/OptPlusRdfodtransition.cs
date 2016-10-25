using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OptPlusRdfodtransition
    {
        public string Prn { get; set; }
        public string EntryDate { get; set; }
        public string EntryTime { get; set; }
        public short? TransCode { get; set; }
        public int? CustomerKey { get; set; }
        public int OdTransitionKey { get; set; }
        public DateTime? DateUpdated { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
