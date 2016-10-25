using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OptPlusBinProduct
    {
        public int OptplusBinProductKey { get; set; }
        public int PrepaidCardBinKey { get; set; }
        public int OptplusProductKey { get; set; }
        public int? VendorProductId { get; set; }
        public int? VendorPackageId { get; set; }
        public int? TestVendorProductId { get; set; }
        public int? TestVendorPackageId { get; set; }

        public virtual OptPlusProduct OptplusProductKeyNavigation { get; set; }
        public virtual PrepaidCardBin PrepaidCardBinKeyNavigation { get; set; }
    }
}
