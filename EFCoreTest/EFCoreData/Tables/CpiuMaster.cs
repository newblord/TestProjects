using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CpiuMaster
    {
        public CpiuMaster()
        {
            CpiuDetail = new HashSet<CpiuDetail>();
        }

        public int CpiuMasterKey { get; set; }
        public DateTime ImportedDatetime { get; set; }
        public string Teller { get; set; }
        public string FileName { get; set; }
        public int CollectionAgencyKey { get; set; }
        public bool Finished { get; set; }
        public string FinishedBy { get; set; }
        public DateTime? FinishedDatetime { get; set; }
        public bool Locked { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockedDatetime { get; set; }

        public virtual ICollection<CpiuDetail> CpiuDetail { get; set; }
        public virtual CollectionAgency CollectionAgencyKeyNavigation { get; set; }
        public virtual Tellerid TellerNavigation { get; set; }
    }
}
