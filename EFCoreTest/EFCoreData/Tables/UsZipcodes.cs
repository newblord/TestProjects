using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class UsZipcodes
    {
        public UsZipcodes()
        {
            LocationUsZipcodesXref = new HashSet<LocationUsZipcodesXref>();
        }

        public string Zipcode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public short Timezone { get; set; }
        public string MsaCode { get; set; }
        public string ZipType { get; set; }
        public int? Dma { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }

        public virtual ICollection<LocationUsZipcodesXref> LocationUsZipcodesXref { get; set; }
        public virtual Msa MsaCodeNavigation { get; set; }
    }
}
