using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Dma
    {
        public int? Dma1 { get; set; }
        public string ZipCode { get; set; }
        public string DmaName { get; set; }
        public string AdditionalDma { get; set; }
        public int? StateCode { get; set; }
        public int? CityCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int? CitySize { get; set; }
        public int? NmrTerr { get; set; }
        public int? DmaRank { get; set; }
        public string MetroIndicator { get; set; }
        public int DmaKey { get; set; }
        public string CityName { get; set; }
    }
}
