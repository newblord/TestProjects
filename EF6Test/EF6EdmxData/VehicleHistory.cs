//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF6EdmxData
{
    using System;
    using System.Collections.Generic;
    
    public partial class VehicleHistory
    {
        public int VEHICLE_HISTORY_KEY { get; set; }
        public int VEHICLE_KEY { get; set; }
        public int CUSTOMER_KEY { get; set; }
        public int LOAN_KEY { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string TELLER { get; set; }
        public short LOCATION { get; set; }
        public decimal VEH_WHOLESALE { get; set; }
        public int VEH_MILEAGE { get; set; }
        public string VEH_CONDITION { get; set; }
        public string VEH_VER_EST { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Loan Loan { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}