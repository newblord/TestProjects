using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class RiccHold
    {
        public int RisreptKey { get; set; }
        public string Reference { get; set; }
        public int CashedCheckKey { get; set; }
        public int? LoanKey { get; set; }
        public short Location { get; set; }
        public DateTime Date { get; set; }
        public int? RisAuditId { get; set; }
        public int CreditcardKey { get; set; }
        public string Cardnum { get; set; }
        public string Nameoncard { get; set; }
        public byte Expmonth { get; set; }
        public int Expyear { get; set; }
        public bool PinlessEligible { get; set; }
        public string Teller { get; set; }
        public int CustomerKey { get; set; }
        public string LoanType { get; set; }
        public string ProductType { get; set; }
        public decimal RiBalance { get; set; }
        public int Riage { get; set; }
        public int Dupe { get; set; }
        public int Void { get; set; }
        public bool IsAdAstra { get; set; }
        public string DepositMethod { get; set; }
        public string Cvv { get; set; }
        public string BillingAddress { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingZipcode { get; set; }
        public bool Expired { get; set; }
        public bool Cvvinvalid { get; set; }
        public int IssuerKey { get; set; }
        public int LienHolderKey { get; set; }
        public string Token { get; set; }
        public byte CardBrand { get; set; }
        public byte CardType { get; set; }
        public short RolloverNum { get; set; }
        public decimal FeeAmt { get; set; }
        public decimal Surchg { get; set; }
        public int AutoRoll { get; set; }
        public bool Selected { get; set; }
        public bool Processed { get; set; }
        public bool Approved { get; set; }
        public string AppErrCode { get; set; }
        public int PtpHeaderKey { get; set; }
        public int PtpDetailKey { get; set; }
        public int CcardTransKey { get; set; }
        public bool Posted { get; set; }
        public int Id { get; set; }
        public int? OptplusCardDetailKey { get; set; }
    }
}
