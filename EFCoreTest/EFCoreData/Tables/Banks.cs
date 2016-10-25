using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Banks
    {
        public Banks()
        {
            Achqueue = new HashSet<Achqueue>();
            BankClassification = new HashSet<BankClassification>();
            Issuer = new HashSet<Issuer>();
        }

        public string Bankaba { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
        public string Areacode { get; set; }
        public string Phone { get; set; }
        public string Riphone { get; set; }
        public bool MainBank { get; set; }
        public string VerifyPhone { get; set; }
        public string Bankphone { get; set; }
        public byte? BankGroup { get; set; }
        public string BankReportNote { get; set; }
        public string BusinessOpensAt { get; set; }
        public int? BanksParentKey { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? FedUpdateDate { get; set; }
        public bool AutomatedMerchantLine { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string Bankcity { get; set; }
        public string Bankstate { get; set; }
        public string Bankzip { get; set; }
        public byte BankFundingMethod { get; set; }
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
        public bool IsGovt { get; set; }

        public virtual ICollection<Achqueue> Achqueue { get; set; }
        public virtual ICollection<BankClassification> BankClassification { get; set; }
        public virtual ICollection<Issuer> Issuer { get; set; }
        public virtual BanksParent BanksParentKeyNavigation { get; set; }
    }
}
