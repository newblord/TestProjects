using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CreditVendorData
    {
        public int CreditVendorDataKey { get; set; }
        public DateTime DateEntered { get; set; }
        public byte VeritecStatus { get; set; }
        public string DefState { get; set; }
        public int LoanKey { get; set; }
        public decimal TransAmount { get; set; }
        public string ClverifyPaymentCode { get; set; }
        public int? ClverifyPaymentNumber { get; set; }
        public byte ClverifyStatus { get; set; }
        public byte DataxStatus { get; set; }
        public int OriginalLoanKey { get; set; }
        public bool IsSentVeritec { get; set; }
        public bool IsSentDatax { get; set; }
        public bool IsSentClverify { get; set; }
        public string SentMsg { get; set; }
        public bool? IsSentGentry { get; set; }
        public short? DaysLate { get; set; }
        public int? CustomerKey { get; set; }
        public byte? ClarityStatus { get; set; }
        public bool? IsSentClarity { get; set; }
    }
}
