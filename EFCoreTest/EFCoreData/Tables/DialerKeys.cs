using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DialerKeys
    {
        public int? Rikey { get; set; }
        public string Reference { get; set; }
        public DateTime? Date { get; set; }
        public string Jobname { get; set; }
        public decimal? Balance { get; set; }
        public decimal? Balancetest { get; set; }
        public bool? Exclude { get; set; }
        public bool? Exported { get; set; }
        public short? RisAuditId { get; set; }
        public DateTime? Followup { get; set; }
        public bool? CourtesyExport { get; set; }
        public int DialerKeysKey { get; set; }
        public bool ExportedToNoble { get; set; }
    }
}
