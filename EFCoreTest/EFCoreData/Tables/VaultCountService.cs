using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class VaultCountService
    {
        public int VaultCountServiceKey { get; set; }
        public int VaultCountKey { get; set; }
        public int ServiceDetailKey { get; set; }
        public int ServiceCnt { get; set; }
        public int ServiceCalc { get; set; }

        public virtual ServiceDetail ServiceDetailKeyNavigation { get; set; }
        public virtual VaultCount VaultCountKeyNavigation { get; set; }
    }
}
