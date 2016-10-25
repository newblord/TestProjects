using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DepositChk
    {
        public DepositChk()
        {
            DepositBag = new HashSet<DepositBag>();
            DepositChkDetail = new HashSet<DepositChkDetail>();
        }

        public int DepositChkKey { get; set; }
        public short Location { get; set; }
        public int? DcGlAcct { get; set; }
        public decimal DcChkTot { get; set; }
        public int DcChkCntr { get; set; }
        public bool DcPraType { get; set; }
        public string DcDepositBy { get; set; }
        public DateTime DcDepositDate { get; set; }
        public bool DcBagType { get; set; }
        public string DcCourierName { get; set; }
        public int TransDetailKey { get; set; }

        public virtual ICollection<DepositBag> DepositBag { get; set; }
        public virtual ICollection<DepositChkDetail> DepositChkDetail { get; set; }
        public virtual Company LocationNavigation { get; set; }
    }
}
