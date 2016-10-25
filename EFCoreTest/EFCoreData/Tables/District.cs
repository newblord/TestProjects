using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class District
    {
        public short DistrictKey { get; set; }
        public byte RegionKey { get; set; }
        public string DistrictName { get; set; }
        public string DistrictManager { get; set; }

        public virtual Region RegionKeyNavigation { get; set; }
    }
}
