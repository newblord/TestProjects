using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class VaultService
    {
        public int VaultServiceKey { get; set; }
        public short Location { get; set; }
        public int ServiceDetailKey { get; set; }
        public int VaultQty { get; set; }

        public virtual ServiceDetail ServiceDetailKeyNavigation { get; set; }
    }
}
