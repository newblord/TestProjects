using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanApplicationAddress
    {
        public LoanApplicationAddress()
        {
            LoanApplicationEmployer = new HashSet<LoanApplicationEmployer>();
        }

        public int LoanApplicationAddressKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public int LoanApplicationKey { get; set; }
        public byte AddressTypeCode { get; set; }
        public string Address1 { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string AddressFormat { get; set; }
        public string AddrStreet { get; set; }
        public string FlatNum { get; set; }
        public string BuildingNum { get; set; }
        public string BuildingName { get; set; }
        public string AddressCsz { get; set; }
        public string AddressLine3 { get; set; }
        public string AddrNum { get; set; }
        public string AddrPreDir { get; set; }
        public string AddrSuffix { get; set; }
        public string AddrPostDir { get; set; }
        public string AddrSuite { get; set; }
        public string AddrSuiteNum { get; set; }
        public string AddressLine { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }

        public virtual ICollection<LoanApplicationEmployer> LoanApplicationEmployer { get; set; }
        public virtual LoanApplication LoanApplicationKeyNavigation { get; set; }
    }
}
