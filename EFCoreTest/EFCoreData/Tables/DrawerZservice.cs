using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DrawerZservice
    {
        public int DrawerzServiceKey { get; set; }
        public int DrawerzKey { get; set; }
        public short Location { get; set; }
        public int ServiceDetailKey { get; set; }
        public int DrawerzQty { get; set; }
        public int CntzQty { get; set; }

        public virtual DrawerZ DrawerzKeyNavigation { get; set; }
        public virtual ServiceDetail ServiceDetailKeyNavigation { get; set; }
    }
}
