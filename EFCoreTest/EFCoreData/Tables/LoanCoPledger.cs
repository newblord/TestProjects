using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanCoPledger
    {
        public LoanCoPledger()
        {
            TitleLoan = new HashSet<TitleLoan>();
        }

        public int LoanCoPledgerKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public string Gender { get; set; }
        public byte HeightFeet { get; set; }
        public byte HeightInches { get; set; }
        public byte Race { get; set; }
        public byte EyeColor { get; set; }
        public byte HairColor { get; set; }
        public string HomePhone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhotoId { get; set; }
        public string PhotoIdType { get; set; }
        public string IssuingAgency { get; set; }
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
        public string AddressFormat { get; set; }
        public string FlatNum { get; set; }
        public string BuildingNum { get; set; }
        public string BuildingName { get; set; }
        public string AddressLine { get; set; }
        public string AddressCsz { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Ssn { get; set; }

        public virtual ICollection<TitleLoan> TitleLoan { get; set; }
    }
}
