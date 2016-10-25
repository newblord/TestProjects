using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ServiceTransDetail
    {
        public int ServiceTransDetailKey { get; set; }
        public int ServiceTransKey { get; set; }
        public string PersonReceived { get; set; }
        public string CountryTo { get; set; }
        public string Occupation { get; set; }
        public string Purpose { get; set; }
        public string BillerName { get; set; }
        public string BillpayCode { get; set; }
        public string BillpayAccountNum { get; set; }
        public bool Exported { get; set; }
        public bool? IsDomestic { get; set; }
        public string ThirdPartyDetails { get; set; }
        public byte? VendorId { get; set; }
        public string WireTransferReceipt { get; set; }

        public virtual ServiceTrans ServiceTransKeyNavigation { get; set; }
    }
}
