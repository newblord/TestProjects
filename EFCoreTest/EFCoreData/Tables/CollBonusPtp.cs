using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CollBonusPtp
    {
        public int? PtpDetailKey { get; set; }
        public int? RisreptKey { get; set; }
        public int? LoanKey { get; set; }
        public string ProductType { get; set; }
        public string LoanType { get; set; }
        public string Teller { get; set; }
        public DateTime? DateEntered { get; set; }
        public decimal? Amount { get; set; }
        public byte? PtpType { get; set; }
        public short? Location { get; set; }
        public int CollBonusPtpKey { get; set; }
    }
}
