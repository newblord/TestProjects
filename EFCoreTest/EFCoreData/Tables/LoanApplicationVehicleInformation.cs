using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanApplicationVehicleInformation
    {
        public int LoanApplicationVehicleInformationKey { get; set; }
        public int LoanApplicationKey { get; set; }
        public int CustomerKey { get; set; }
        public DateTime DateEntered { get; set; }
        public decimal VehWholesale { get; set; }
        public int VehMileage { get; set; }
        public string VehCondition { get; set; }
        public string VehPlate { get; set; }
        public string VehSticker { get; set; }
        public DateTime? VehRegDate { get; set; }
        public DateTime? VehRegExpire { get; set; }
        public string VehRegState { get; set; }
        public string VehTitleNum { get; set; }
        public string VehOdoCode { get; set; }
        public string LegalStatus { get; set; }
        public string StateCustNum { get; set; }
        public string InsName { get; set; }
        public string InsPhone { get; set; }
        public bool InsFullCover { get; set; }
        public string InsPolicyNum { get; set; }
        public bool PayVerified { get; set; }
        public string AndOrName { get; set; }
        public decimal? LienBalance { get; set; }
        public string LienAcctNum { get; set; }
        public string VehVin { get; set; }
        public string VehMake { get; set; }
        public string VehModel { get; set; }
        public string VehBody { get; set; }
        public string VehEngine { get; set; }
        public string VehTrans { get; set; }
        public string VehDrive { get; set; }
        public short VehYear { get; set; }
        public decimal VehRetail { get; set; }
        public bool IsClearTitle { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual LoanApplication LoanApplicationKeyNavigation { get; set; }
    }
}
