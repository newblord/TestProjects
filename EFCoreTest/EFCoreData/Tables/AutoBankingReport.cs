using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AutoBankingReport
    {
        public int AutobankingreportKey { get; set; }
        public int ExternalAppsKey { get; set; }
        public DateTime StartDate { get; set; }
        public string Reference { get; set; }
        public string Issuer { get; set; }
        public short? Location { get; set; }
        public string Acct { get; set; }
        public string BankAba { get; set; }
        public string CheckNo { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Balance { get; set; }
        public string AuditCat { get; set; }
        public string Results { get; set; }
        public DateTime? RiDate { get; set; }
    }
}
