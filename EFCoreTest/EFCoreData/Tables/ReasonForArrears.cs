using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ReasonForArrears
    {
        public int ReasonForArrearsKey { get; set; }
        public DateTime DateUpdated { get; set; }
        public int UpdatedTellerIdKey { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public virtual Tellerid UpdatedTellerIdKeyNavigation { get; set; }
    }
}
