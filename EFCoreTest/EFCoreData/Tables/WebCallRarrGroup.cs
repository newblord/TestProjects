using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallRarrGroup
    {
        public int WebCallRarrGroupKey { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }
        public int? Points { get; set; }
        public int RarrCountOffset { get; set; }
    }
}
