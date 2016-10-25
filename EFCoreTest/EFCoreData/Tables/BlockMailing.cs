using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class BlockMailing
    {
        public int BlockMailingKey { get; set; }
        public int CustomerKey { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
