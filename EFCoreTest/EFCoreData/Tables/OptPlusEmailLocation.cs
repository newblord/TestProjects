using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OptPlusEmailLocation
    {
        public int OptplusEmailLocationKey { get; set; }
        public int OptplusEmailKey { get; set; }
        public short Location { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }

        public virtual OptPlusEmail OptplusEmailKeyNavigation { get; set; }
    }
}
