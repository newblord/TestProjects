using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CreditCardAttempts
    {
        public int CreditCardTransKey { get; set; }
        public bool Paid { get; set; }
        public DateTime DateEntered { get; set; }
        public byte TransType { get; set; }
        public bool IsRecurring { get; set; }
        public string CardNumber { get; set; }
        public string Token { get; set; }
    }
}
