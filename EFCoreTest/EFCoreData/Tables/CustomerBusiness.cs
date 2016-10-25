using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerBusiness
    {
        public CustomerBusiness()
        {
            BusinessLoan = new HashSet<BusinessLoan>();
        }

        public int CustomerBusinessKey { get; set; }
        public int CustomerKey { get; set; }
        public string BusinessName { get; set; }
        public byte BusinessTypeCode { get; set; }
        public byte LegalTypeCode { get; set; }
        public string TaxIdNum { get; set; }
        public string BusinessPhoneNum { get; set; }
        public DateTime? BusinessStartDate { get; set; }
        public short NumEmployees { get; set; }
        public decimal VerMonthlyNetInc { get; set; }
        public decimal VerBankDeposits { get; set; }
        public string AddrNum { get; set; }
        public string AddrPostDir { get; set; }
        public string AddrPreDir { get; set; }
        public string AddrStreet { get; set; }
        public string AddrSuffix { get; set; }
        public string AddrSuite { get; set; }
        public string AddrSuiteNum { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public bool IsActive { get; set; }
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

        public virtual ICollection<BusinessLoan> BusinessLoan { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
