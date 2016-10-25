using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class SpecialMessageLocation
    {
        public int SpecialMessageLocationKey { get; set; }
        public int? SpecialMessageKey { get; set; }
        public short? Location { get; set; }

        public virtual SpecialMessage SpecialMessageKeyNavigation { get; set; }
    }
}
