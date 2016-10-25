using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CreditCards
    {
        public CreditCards()
        {
            CreditCardXref = new HashSet<CreditCardXref>();
            Loan = new HashSet<Loan>();
            MpayLoan = new HashSet<MpayLoan>();
            OptPlusCardDetailOtherCreditcardKeyNavigation = new HashSet<OptPlusCardDetail>();
            PrepaidCardStopPayment = new HashSet<PrepaidCardStopPayment>();
            RolloverRequest = new HashSet<RolloverRequest>();
        }

        public int CreditCardKey { get; set; }
        public int CustomerKey { get; set; }
        public string NameOnCard { get; set; }
        public string CardNum { get; set; }
        public byte ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public DateTime? Lastupdate { get; set; }
        public bool CcStatus { get; set; }
        public bool Deleted { get; set; }
        public string LastResult { get; set; }
        public bool Expired { get; set; }
        public bool CvvInvalid { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public bool PinlessEligible { get; set; }
        public DateTime? RiccEffDate { get; set; }
        public string Token { get; set; }
        public byte CardBrand { get; set; }
        public byte CardType { get; set; }
        public string BillingAddress1 { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingZipcode { get; set; }
        public string BillingCounty { get; set; }
        public string BillingCountry { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string DeletedBy { get; set; }
        public string AddressFormat { get; set; }
        public string BillingAddrStreet { get; set; }
        public string BillingFlatNum { get; set; }
        public string BillingBuildingNum { get; set; }
        public string BillingBuildingName { get; set; }
        public string BillingAddressLine { get; set; }
        public string BillingAddressCsz { get; set; }
        public string BillingAddressLine3 { get; set; }
        public string BillingAddressLine1 { get; set; }
        public string BillingAddressLine2 { get; set; }
        public string AliasId { get; set; }
        public bool MaestroSwitch { get; set; }
        public bool Electron { get; set; }
        public bool ProcessorFlaggedCredit { get; set; }
        public string MagStrip { get; set; }
        public string Ccv { get; set; }

        public virtual ICollection<CreditCardXref> CreditCardXref { get; set; }
        public virtual ICollection<Loan> Loan { get; set; }
        public virtual ICollection<MpayLoan> MpayLoan { get; set; }
        public virtual OptPlusCardDetail OptPlusCardDetailCreditCardKeyNavigation { get; set; }
        public virtual ICollection<OptPlusCardDetail> OptPlusCardDetailOtherCreditcardKeyNavigation { get; set; }
        public virtual ICollection<PrepaidCardStopPayment> PrepaidCardStopPayment { get; set; }
        public virtual ICollection<RolloverRequest> RolloverRequest { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
