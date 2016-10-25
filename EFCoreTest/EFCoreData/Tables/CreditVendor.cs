using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CreditVendor
    {
        public int CreditVendorKey { get; set; }
        public DateTime LastDataxRunTime { get; set; }
        public DateTime LastClverifyRunTime { get; set; }
        public DateTime LastVeritecMiRunTime { get; set; }
        public DateTime LastVeritecOkRunTime { get; set; }
        public DateTime LastVeritecNdRunTime { get; set; }
        public bool DataxActive { get; set; }
        public bool ClverifyActive { get; set; }
        public bool VeritecMiActive { get; set; }
        public bool VeritecOkActive { get; set; }
        public bool VeritecNdActive { get; set; }
        public bool GentryActive { get; set; }
        public DateTime LastGentryRunTime { get; set; }
        public DateTime LastVeritecWaRunTime { get; set; }
        public bool VeritecWaActive { get; set; }
        public DateTime LastFtDailyRunTime { get; set; }
        public DateTime? LastVeritecWiRunTime { get; set; }
        public bool? VeritecWiActive { get; set; }
        public DateTime? LastVeritecIlRunTime { get; set; }
        public bool? VeritecIlActive { get; set; }
        public bool? TeletrackukActive { get; set; }
        public DateTime? LastTeletrackukRunTime { get; set; }
        public DateTime? LastClarityRunTime { get; set; }
        public bool? ClarityActive { get; set; }
        public bool IsDataxBmReportingActive { get; set; }
    }
}
