using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DrawerZ
    {
        public DrawerZ()
        {
            DrawerMaster = new HashSet<DrawerMaster>();
            DrawerZcash = new HashSet<DrawerZcash>();
            DrawerZservice = new HashSet<DrawerZservice>();
            OverShort = new HashSet<OverShort>();
            TransDetail = new HashSet<TransDetail>();
        }

        public int DrawerzKey { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public decimal DrawerzChk { get; set; }
        public decimal DrawerzPra { get; set; }
        public int DrawerzChkCnt { get; set; }
        public int DrawerzPraCnt { get; set; }
        public decimal DrawerzMisc { get; set; }
        public decimal DrawerzCcard { get; set; }
        public decimal CntzMisc { get; set; }
        public decimal CntzCcard { get; set; }
        public string OsReason { get; set; }
        public string OsCategory { get; set; }
        public DateTime DrawerOpened { get; set; }
        public int DrawerzBagChkCnt { get; set; }
        public decimal DrawerzBagChkAmt { get; set; }
        public decimal PraDebit { get; set; }
        public int PraDebitCount { get; set; }

        public virtual ICollection<DrawerMaster> DrawerMaster { get; set; }
        public virtual ICollection<DrawerZcash> DrawerZcash { get; set; }
        public virtual ICollection<DrawerZservice> DrawerZservice { get; set; }
        public virtual ICollection<OverShort> OverShort { get; set; }
        public virtual ICollection<TransDetail> TransDetail { get; set; }
    }
}
