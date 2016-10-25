using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebReferralMethod
    {
        public int WebReferralMethodKey { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int SortOrder { get; set; }
    }
}
