using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CapsHold
    {
        public CapsHold()
        {
            CapsCctxref = new HashSet<CapsCctxref>();
        }

        public int CapsHoldKey { get; set; }
        public int CapsRunKey { get; set; }
        public int RisreptKey { get; set; }
        public int LoanKey { get; set; }
        public int CashedCheckKey { get; set; }
        public int OptplusCardDetailKey { get; set; }
        public int CustomerKey { get; set; }
        public int IssuerKey { get; set; }
        public int PtpHeaderKey { get; set; }
        public int PtpDetailKey { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal AmtToCollect { get; set; }
        public string DepositMethod { get; set; }
        public int DepositOrder { get; set; }
        public string BillingAddress { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingZipcode { get; set; }
        public short Location { get; set; }
        public int? RisAuditId { get; set; }
        public int CreditcardKey { get; set; }
        public string Cardnum { get; set; }
        public string Nameoncard { get; set; }
        public byte Expmonth { get; set; }
        public int Expyear { get; set; }
        public string Token { get; set; }
        public byte CardBrand { get; set; }
        public byte CardType { get; set; }
        public string Teller { get; set; }
        public string LoanType { get; set; }
        public string ProductType { get; set; }
        public bool IsAdAstra { get; set; }
        public bool Selected { get; set; }
        public bool Processed { get; set; }
        public bool Approved { get; set; }
        public bool Posted { get; set; }
        public string AppErrCode { get; set; }
        public byte CapsSkipReasonKey { get; set; }
        public int RiAge { get; set; }
        public DateTime? LastDcardAttemptDate { get; set; }
        public int? DcardConsecutiveDays { get; set; }
        public int? LastCctransKey { get; set; }
        public decimal? AmtCollected { get; set; }
        public bool ExcludeFromCap { get; set; }
        public decimal TotFeeAmt { get; set; }
        public string CapsAttemptId { get; set; }
        public DateTime? CalcPayDate { get; set; }

        public virtual ICollection<CapsCctxref> CapsCctxref { get; set; }
        public virtual CapsSkipReason CapsSkipReasonKeyNavigation { get; set; }
    }
}
