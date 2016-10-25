using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DrawerXservice
    {
        public int DrawerxServiceKey { get; set; }
        public int DrawerxKey { get; set; }
        public short Location { get; set; }
        public int ServiceDetailKey { get; set; }
        public int DrawerxQty { get; set; }

        public virtual DrawerX DrawerxKeyNavigation { get; set; }
        public virtual ServiceDetail ServiceDetailKeyNavigation { get; set; }
    }
}
