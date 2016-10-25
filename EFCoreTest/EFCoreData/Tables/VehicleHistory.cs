using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class VehicleHistory
    {
        public int VehicleHistoryKey { get; set; }
        public int VehicleKey { get; set; }
        public int CustomerKey { get; set; }
        public int LoanKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public short Location { get; set; }
        public decimal VehWholesale { get; set; }
        public int VehMileage { get; set; }
        public string VehCondition { get; set; }
        public string VehVerEst { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
        public virtual Vehicle VehicleKeyNavigation { get; set; }
    }
}
