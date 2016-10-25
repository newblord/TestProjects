using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DrawerService
    {
        public int DrawerServiceKey { get; set; }
        public int DrawerKey { get; set; }
        public short Location { get; set; }
        public int ServiceDetailKey { get; set; }
        public int DrawerQty { get; set; }

        public virtual DrawerMaster DrawerKeyNavigation { get; set; }
        public virtual ServiceDetail ServiceDetailKeyNavigation { get; set; }
    }
}
