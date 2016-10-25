using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class TransDetailService
    {
        public int TransDetailServiceKey { get; set; }
        public int TransDetailKey { get; set; }
        public int? TransDetailAcctKey { get; set; }
        public string ServiceFrom { get; set; }
        public string ServiceTo { get; set; }
        public int ServiceDetailKey { get; set; }
        public int ServiceQty { get; set; }
        public int? DrawerKey { get; set; }

        public virtual ServiceDetail ServiceDetailKeyNavigation { get; set; }
        public virtual TransDetail TransDetailKeyNavigation { get; set; }
    }
}
