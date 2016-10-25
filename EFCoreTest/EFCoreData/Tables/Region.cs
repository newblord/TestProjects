using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Region
    {
        public Region()
        {
            District = new HashSet<District>();
        }

        public byte RegionKey { get; set; }
        public string RegionName { get; set; }
        public string RegionManager { get; set; }

        public virtual ICollection<District> District { get; set; }
    }
}
