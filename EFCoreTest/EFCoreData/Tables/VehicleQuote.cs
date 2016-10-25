using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class VehicleQuote
    {
        public int VehicleQuoteKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public short Location { get; set; }
        public string Vin { get; set; }
        public decimal MileageValue { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal WholesalePrice { get; set; }
        public int Mileage { get; set; }
        public string Plate { get; set; }
    }
}
