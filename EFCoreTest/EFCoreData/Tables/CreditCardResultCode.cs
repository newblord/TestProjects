using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CreditCardResultCode
    {
        public short CreditCardResultCodeKey { get; set; }
        public string ResultCode { get; set; }
        public string ResultText { get; set; }
        public bool MarkCardInvalid { get; set; }
        public bool BlockCard { get; set; }
        public bool IsApproved { get; set; }
        public bool IsSystemError { get; set; }
        public bool MarkCardExpired { get; set; }
        public bool CanSecureInternetLoan { get; set; }
        public bool CanSecureStoreLoan { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsAvApproved { get; set; }
        public byte? CreditCardVendorKey { get; set; }
        public string ResultDescription { get; set; }
        public byte? ResultCodeTypeId { get; set; }
        public bool MarkCreditCard { get; set; }

        public virtual CreditCardVendor CreditCardVendorKeyNavigation { get; set; }
    }
}
