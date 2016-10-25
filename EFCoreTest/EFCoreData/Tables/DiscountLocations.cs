using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DiscountLocations
    {
        public int DiscountLocationsKey { get; set; }
        public int DiscountsKey { get; set; }
        public short Location { get; set; }

        public virtual DiscountMaster DiscountsKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
    }
}
