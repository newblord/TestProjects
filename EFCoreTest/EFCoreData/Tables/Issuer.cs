using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Issuer
    {
        public Issuer()
        {
            IssuerEdit = new HashSet<IssuerEdit>();
            OptPlusCardDetail = new HashSet<OptPlusCardDetail>();
            RbcEfundBatchDetail = new HashSet<RbcEfundBatchDetail>();
            Risrept = new HashSet<Risrept>();
        }

        public int IssuerKey { get; set; }
        public int? CustomerKey { get; set; }
        public DateTime Date { get; set; }
        public string Tlr { get; set; }
        public short Location { get; set; }
        public string Issuer1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Phone { get; set; }
        public string AcctNo { get; set; }
        public string BankId { get; set; }
        public decimal Limit { get; set; }
        public string Type { get; set; }
        public bool Bounced { get; set; }
        public string Note { get; set; }
        public string Tupt { get; set; }
        public DateTime? Tupd { get; set; }
        public short? Tloc { get; set; }
        public bool BlockCheck { get; set; }
        public int? BankStatusId { get; set; }
        public bool AchBlock { get; set; }
        public string PhoneExt { get; set; }
        public string Address1 { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
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
        public bool? Flash { get; set; }
        public int? BlockReasonKey { get; set; }
        public bool? SystemBlock { get; set; }
        public long? AcctNoNum { get; set; }

        public virtual ICollection<IssuerEdit> IssuerEdit { get; set; }
        public virtual ICollection<OptPlusCardDetail> OptPlusCardDetail { get; set; }
        public virtual ICollection<RbcEfundBatchDetail> RbcEfundBatchDetail { get; set; }
        public virtual ICollection<Risrept> Risrept { get; set; }
        public virtual Banks Bank { get; set; }
        public virtual BankStatus BankStatus { get; set; }
        public virtual BlockReason BlockReasonKeyNavigation { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
        public virtual UsStates StateNavigation { get; set; }
        public virtual Company TlocNavigation { get; set; }
        public virtual Tellerid TlrNavigation { get; set; }
        public virtual Tellerid TuptNavigation { get; set; }
    }
}
