using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AdAstraWebInventory
    {
        public int RisreptKey { get; set; }
        public string Reference { get; set; }
        public string Ssn { get; set; }
        public DateTime? Dob { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public decimal RiBalance { get; set; }
        public bool IsEligible { get; set; }
        public int? RisAuditId { get; set; }
    }
}
