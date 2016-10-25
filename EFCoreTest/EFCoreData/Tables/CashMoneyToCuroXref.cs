using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CashMoneyToCuroXref
    {
        public int CustomerKey { get; set; }
        public long ClientKey { get; set; }
        public DateTime? DateEntered { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
