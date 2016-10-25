using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LienHolder
    {
        public LienHolder()
        {
            TitleLoan = new HashSet<TitleLoan>();
        }

        public int LienHolderKey { get; set; }
        public string LienHolderName { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Phone { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public short EnteredLocation { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public short? UpdatedLocation { get; set; }
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

        public virtual ICollection<TitleLoan> TitleLoan { get; set; }
    }
}
