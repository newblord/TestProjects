using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Ris
    {
        public DateTime Date { get; set; }
        public string Tlr { get; set; }
        public short Location { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }
        public DateTime? Followup { get; set; }
        public byte? Ptyp { get; set; }
        public DateTime? Xtime { get; set; }
        public DateTime? Ztime { get; set; }
        public DateTime? Btime { get; set; }
        public int RisId { get; set; }
        public DateTime? Btime2 { get; set; }
        public bool Prepay { get; set; }
        public int? DosRefno { get; set; }
        public int? ReverseRisId { get; set; }
        public int RisAuditId { get; set; }
        public int RisTaskId { get; set; }
        public int RisreptKey { get; set; }
        public string DosMigratedId { get; set; }
        public int? TransDetailKey { get; set; }
        public short? GlAcct { get; set; }

        public virtual Risaudit RisAudit { get; set; }
        public virtual RisTask RisTask { get; set; }
        public virtual Risrept RisreptKeyNavigation { get; set; }
        public virtual Tellerid TlrNavigation { get; set; }
    }
}
