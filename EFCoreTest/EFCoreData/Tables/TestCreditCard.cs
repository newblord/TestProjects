using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class TestCreditCard
    {
        public int TestCreditCardKey { get; set; }
        public string CardNumber { get; set; }
        public bool Visa { get; set; }
        public bool Mc { get; set; }
        public bool InUse { get; set; }
        public decimal? GuaranteeAmt { get; set; }
        public string Token { get; set; }
        public int TestScenario { get; set; }
    }
}
