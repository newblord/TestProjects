using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class InvalidCustomerAddress
    {
        public int IcaKey { get; set; }
        public int CustomerKey { get; set; }
        public int? CustomerAddressKey { get; set; }
        public byte Reason { get; set; }
        public string HomeAddrNum { get; set; }
        public string HomeAddrPostDir { get; set; }
        public string HomeAddrPreDir { get; set; }
        public string HomeAddrStreet { get; set; }
        public string HomeAddrSuffix { get; set; }
        public string HomeAddrSuite { get; set; }
        public string HomeAddrSuiteNum { get; set; }
        public string HomeCity { get; set; }
        public string HomeState { get; set; }
        public string HomeZipcode { get; set; }
        public string HomeAddress { get; set; }
    }
}
