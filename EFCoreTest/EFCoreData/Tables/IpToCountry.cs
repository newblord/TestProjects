using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class IpToCountry
    {
        public long FromIp { get; set; }
        public long ToIp { get; set; }
        public string CountryCode { get; set; }
        public long IptocountryKey { get; set; }
    }
}
