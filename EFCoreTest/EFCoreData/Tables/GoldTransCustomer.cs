using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class GoldTransCustomer
    {
        public int GoldTransCustomerKey { get; set; }
        public int CustomerKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public string Gender { get; set; }
        public byte HeightFeet { get; set; }
        public byte HeightInches { get; set; }
        public short Weight { get; set; }
        public byte Race { get; set; }
        public byte EyeColor { get; set; }
        public byte HairColor { get; set; }
        public string HomePhone { get; set; }
        public string EmployerName { get; set; }
        public string PlateNumber { get; set; }
        public string PlateState { get; set; }
        public int GoldTransKey { get; set; }
        public bool RequireMidName { get; set; }
        public string CustMidName { get; set; }
        public bool RequireNothing { get; set; }
        public bool RequireGender { get; set; }
        public bool RequireHeight { get; set; }
        public bool RequireWeight { get; set; }
        public bool RequireRace { get; set; }
        public bool RequireEyeColor { get; set; }
        public bool RequireHairColor { get; set; }
        public bool RequireMinAge { get; set; }
        public byte RequireAgeValue { get; set; }
        public bool RequireHomePhone { get; set; }
        public bool RequireEmployerName { get; set; }
        public bool RequirePlateNumber { get; set; }
        public bool RequirePlateState { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual GoldTrans GoldTransKeyNavigation { get; set; }
    }
}
