using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class MarketingInvitation
    {
        public int MarketingInvitationKey { get; set; }
        public long ReservationCode { get; set; }
        public int? VisitorKey { get; set; }
        public int? LoanApplicationKey { get; set; }
        public string FullName { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string NameSuffix { get; set; }
        public string SecondaryAddress { get; set; }
        public string PrimaryAddress { get; set; }
        public string StreetNumber { get; set; }
        public string StreetPreDirectional { get; set; }
        public string StreetName { get; set; }
        public string StreetSuffix { get; set; }
        public string StreetPostDirectional { get; set; }
        public string UnitDesignator { get; set; }
        public string UnitNumber { get; set; }
        public string CityStateZipZip4 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Zip4 { get; set; }
        public string CarrierRouteTypeWithNumber { get; set; }
        public int? DeliveryPointBarcode { get; set; }
        public string LineOfTravel { get; set; }
        public int? StateCountyCode { get; set; }
        public bool? DisasterZipFlag { get; set; }
        public string CountyName { get; set; }
        public string KeyCode { get; set; }
        public string MailType { get; set; }
        public DateTime? MailDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal? ApprovedAmount { get; set; }
        public string IdentificationInfo { get; set; }
        public string LoanType { get; set; }
        public string ProductType { get; set; }
        public int? LoanKey { get; set; }
        public decimal? MinimumIncome { get; set; }
    }
}
