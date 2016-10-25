using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PrepaidCardBinCompany
    {
        public int PrepaidCardBinCompanyKey { get; set; }
        public int PrepaidCardBinKey { get; set; }
        public short Location { get; set; }
        public int? PrepaidCardGroupKey { get; set; }
        public bool? AllowAssignCards { get; set; }
        public bool? AllowLoads { get; set; }
        public bool? AllowUnloads { get; set; }
        public bool? AllowLostStolen { get; set; }
        public bool? AllowChangeProduct { get; set; }
        public bool? AllowDirectDeposit { get; set; }
        public string VendorUatClientid { get; set; }
        public string VendorProdClientid { get; set; }

        public virtual Company LocationNavigation { get; set; }
        public virtual PrepaidCardBin PrepaidCardBinKeyNavigation { get; set; }
        public virtual PrepaidCardGroup PrepaidCardGroupKeyNavigation { get; set; }
    }
}
