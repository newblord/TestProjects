using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            TitleLoan = new HashSet<TitleLoan>();
            VehicleHistory = new HashSet<VehicleHistory>();
        }

        public int VehicleKey { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public string VehVin { get; set; }
        public string VehMake { get; set; }
        public string VehModel { get; set; }
        public string VehBody { get; set; }
        public string VehEngine { get; set; }
        public string VehTrans { get; set; }
        public string VehDrive { get; set; }
        public string VehMiscEquip1 { get; set; }
        public string VehMiscEquip2 { get; set; }
        public string VehMiscEquip3 { get; set; }
        public short VehYear { get; set; }
        public decimal ListPrice { get; set; }
        public string VehColor { get; set; }
        public string FuelType { get; set; }
        public string Plate { get; set; }

        public virtual ICollection<TitleLoan> TitleLoan { get; set; }
        public virtual ICollection<VehicleHistory> VehicleHistory { get; set; }
        public virtual Company LocationNavigation { get; set; }
    }
}
