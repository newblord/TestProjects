using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WireTransferMatch
    {
        public WireTransferMatch()
        {
            WireTransferMatchEdit = new HashSet<WireTransferMatchEdit>();
        }

        public int WireTransferMatchKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public bool IsMatched { get; set; }
        public int? CustomerKey { get; set; }
        public short? Location { get; set; }
        public int? TransDetailKey { get; set; }
        public int? ServiceTransDetailKey { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool MatchedByBatch { get; set; }
        public string BatchName { get; set; }
        public string WireTransferReceipt { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal? PrincipalAmount { get; set; }
        public decimal? FeeAmount { get; set; }
        public decimal? CommissionAmount { get; set; }
        public decimal? TotalAmount { get; set; }
        public bool Sender { get; set; }
        public bool Receiver { get; set; }
        public string SenderFirstName { get; set; }
        public string SenderLastName { get; set; }
        public string SenderMiddleInitial { get; set; }
        public string SenderFullName { get; set; }
        public string SenderStreet { get; set; }
        public string SenderCity { get; set; }
        public string SenderState { get; set; }
        public string SenderZipCode { get; set; }
        public string SenderCountryCode2Char { get; set; }
        public string SenderCountryCode3Char { get; set; }
        public string SenderPhone { get; set; }
        public string SenderTaxId { get; set; }
        public string SenderIdType { get; set; }
        public string SenderIdNumber { get; set; }
        public string SenderIdAuthority { get; set; }
        public string SenderDob { get; set; }
        public string ReceiverFirstName { get; set; }
        public string ReceiverLastName { get; set; }
        public string ReceiverMiddleInitial { get; set; }
        public string ReceiverFullName { get; set; }
        public string ReceiverStreet { get; set; }
        public string ReceiverCity { get; set; }
        public string ReceiverState { get; set; }
        public string ReceiverZipCode { get; set; }
        public string ReceiverCountryCode2Char { get; set; }
        public string ReceiverCountryCode3Char { get; set; }
        public string ReceiverPhone { get; set; }
        public string ReceiverTaxId { get; set; }
        public string ReceiverIdType { get; set; }
        public string ReceiverIdNumber { get; set; }
        public string ReceiverIdAuthority { get; set; }
        public string ReceiverDob { get; set; }
        public int? RunMasterKey { get; set; }

        public virtual ICollection<WireTransferMatchEdit> WireTransferMatchEdit { get; set; }
    }
}
