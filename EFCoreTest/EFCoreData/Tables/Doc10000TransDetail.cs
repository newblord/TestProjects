using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Doc10000TransDetail
    {
        public int Doc10000TransDetailKey { get; set; }
        public int Doc10000TransKey { get; set; }
        public int TransDetailKey { get; set; }

        public virtual Doc10000Trans Doc10000TransKeyNavigation { get; set; }
        public virtual TransDetail TransDetailKeyNavigation { get; set; }
    }
}
