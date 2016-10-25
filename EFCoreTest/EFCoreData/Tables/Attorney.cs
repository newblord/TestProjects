using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Attorney
    {
        public Attorney()
        {
            AttorneyLoan = new HashSet<AttorneyLoan>();
            AttorneyPayment = new HashSet<AttorneyPayment>();
        }

        public short AttorneyKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public string AttorneyName { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string PhoneNumber { get; set; }
        public string FtpAddress { get; set; }
        public short CommissionPct { get; set; }
        public bool IsActive { get; set; }
        public string Address1 { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string AddressFormat { get; set; }
        public string AddrStreet { get; set; }
        public string FlatNum { get; set; }
        public string BuildingNum { get; set; }
        public string BuildingName { get; set; }
        public string AddressLine { get; set; }
        public string AddressCsz { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }

        public virtual ICollection<AttorneyLoan> AttorneyLoan { get; set; }
        public virtual ICollection<AttorneyPayment> AttorneyPayment { get; set; }
    }
}
