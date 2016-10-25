using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PromiseToPayDetail
    {
        public PromiseToPayDetail()
        {
            FormLetterPrinted = new HashSet<FormLetterPrinted>();
            PromiseToPayDetailEdit = new HashSet<PromiseToPayDetailEdit>();
            PromiseToPayDetailTrans = new HashSet<PromiseToPayDetailTrans>();
        }

        public int PtpDetailKey { get; set; }
        public int PtpPromiseKey { get; set; }
        public byte PtpMethod { get; set; }
        public DateTime PtpOrigDueDate { get; set; }
        public DateTime PtpCurrDueDate { get; set; }
        public decimal PtpDueAmt { get; set; }
        public string PtpStatus { get; set; }
        public DateTime? PtpPaidDate { get; set; }
        public string PtpCcNumber { get; set; }
        public short PtpCcExpYear { get; set; }
        public byte? PtpCcExpMonth { get; set; }
        public string PtpCcNameOnCard { get; set; }
        public string PtpCcCcv { get; set; }
        public string PtpBankId { get; set; }
        public string PtpAcctNo { get; set; }
        public string PtpNameOnAccount { get; set; }
        public decimal? PtpPaidAmt { get; set; }
        public int? TransDetailKey { get; set; }
        public string PtpCcBillingCity { get; set; }
        public string PtpCcBillingState { get; set; }
        public string PtpCcBillingZipcode { get; set; }
        public byte PtpCcTimeSlot { get; set; }
        public string PtpCcBillingAddress1 { get; set; }
        public string PtpCcBillingCounty { get; set; }
        public string PtpCcBillingCountry { get; set; }
        public string PtpToken { get; set; }
        public byte PtpCardBrand { get; set; }
        public byte PtpCardType { get; set; }
        public string AddressFormat { get; set; }
        public string PtpCcBillingAddrStreet { get; set; }
        public string PtpCcBillingFlatNum { get; set; }
        public string PtpCcBillingBuildingNum { get; set; }
        public string PtpCcBillingBuildingName { get; set; }
        public string PtpCcBillingAddressLine { get; set; }
        public string PtpCcBillingAddressCsz { get; set; }
        public string PtpCcBillingAddressLine3 { get; set; }
        public string PtpCcBillingAddressLine1 { get; set; }
        public string PtpCcBillingAddressLine2 { get; set; }

        public virtual ICollection<FormLetterPrinted> FormLetterPrinted { get; set; }
        public virtual ICollection<PromiseToPayDetailEdit> PromiseToPayDetailEdit { get; set; }
        public virtual ICollection<PromiseToPayDetailTrans> PromiseToPayDetailTrans { get; set; }
        public virtual PromiseToPay PtpPromiseKeyNavigation { get; set; }
    }
}
