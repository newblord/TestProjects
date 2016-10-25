using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AmladditionalParty
    {
        public int AmlAdditionalPartyKey { get; set; }
        public int? TransDetailKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public string EntityName { get; set; }
        public string FirstName { get; set; }
        public string MidInitial { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? Dob { get; set; }
        public int? AmlOccupationKey { get; set; }
        public string AddressFormat { get; set; }
        public string AddrNum { get; set; }
        public string AddrPreDir { get; set; }
        public string AddrStreet { get; set; }
        public string AddrSuffix { get; set; }
        public string AddrPostDir { get; set; }
        public string AddrSuite { get; set; }
        public string AddrSuiteNum { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string FlatNum { get; set; }
        public string BuildingNum { get; set; }
        public string BuildingName { get; set; }
        public string IdType { get; set; }
        public string IdNumber { get; set; }
        public string IdState { get; set; }
        public int? CountryKey { get; set; }
        public string TaxId { get; set; }
        public string Purpose { get; set; }
        public string Relationship { get; set; }
        public bool IsEntity { get; set; }
        public bool IsRegisteredCharity { get; set; }
        public string IncorporationNumber { get; set; }
        public string IncorporationPlace { get; set; }
        public string BusinessType { get; set; }
        public string AddressCsz { get; set; }
        public string AddressLine { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }

        public virtual Amloccupation AmlOccupationKeyNavigation { get; set; }
        public virtual Country CountryKeyNavigation { get; set; }
        public virtual TransDetail TransDetailKeyNavigation { get; set; }
    }
}
