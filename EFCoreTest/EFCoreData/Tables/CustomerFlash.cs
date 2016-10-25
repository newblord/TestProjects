using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerFlash
    {
        public int CustomerKey { get; set; }
        public int SpecialMessageKey { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateExpired { get; set; }
    }
}
