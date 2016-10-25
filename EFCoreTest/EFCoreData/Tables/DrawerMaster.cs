using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DrawerMaster
    {
        public DrawerMaster()
        {
            DrawerMasterParsedCash = new HashSet<DrawerMasterParsedCash>();
            DrawerService = new HashSet<DrawerService>();
        }

        public int DrawerKey { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public DateTime? DrawerOpened { get; set; }
        public decimal? DrawerMisc { get; set; }
        public decimal DrawerCcard { get; set; }
        public decimal DrawerChk { get; set; }
        public decimal DrawerPra { get; set; }
        public int DrawerChkCnt { get; set; }
        public int DrawerPraCnt { get; set; }
        public bool AuditCompleted { get; set; }
        public int DrawerBagChkCnt { get; set; }
        public decimal DrawerBagChkAmt { get; set; }
        public decimal PraDebit { get; set; }
        public int PraDebitCount { get; set; }
        public int DrawerzKey { get; set; }

        public virtual ICollection<DrawerMasterParsedCash> DrawerMasterParsedCash { get; set; }
        public virtual ICollection<DrawerService> DrawerService { get; set; }
        public virtual DrawerZ DrawerzKeyNavigation { get; set; }
    }
}
