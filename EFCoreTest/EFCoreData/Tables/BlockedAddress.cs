using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class BlockedAddress
    {
        public int BlockedAddressKey { get; set; }
        public string BuildingName { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string DeletedBy { get; set; }
        public bool Active { get; set; }
        public bool CompareBuildingName { get; set; }
        public bool CompareStreetName { get; set; }
        public bool CompareCity { get; set; }
        public bool CompareZipcode { get; set; }
    }
}
