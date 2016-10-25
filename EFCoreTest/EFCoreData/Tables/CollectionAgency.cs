using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CollectionAgency
    {
        public CollectionAgency()
        {
            CollectionAgencyPct = new HashSet<CollectionAgencyPct>();
            CpiuMaster = new HashSet<CpiuMaster>();
        }

        public int CollectionAgencyKey { get; set; }
        public string AgencyName { get; set; }
        public string AgencyCode { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Phone { get; set; }
        public string PhoneExt { get; set; }
        public string ContactName { get; set; }
        public bool IsActive { get; set; }
        public short MaxDaysPctRange1 { get; set; }
        public short MaxDaysPctRange2 { get; set; }
        public decimal PctRange1 { get; set; }
        public decimal PctRange2 { get; set; }
        public string Email { get; set; }
        public bool IsDmc { get; set; }

        public virtual ICollection<CollectionAgencyPct> CollectionAgencyPct { get; set; }
        public virtual ICollection<CpiuMaster> CpiuMaster { get; set; }
    }
}
