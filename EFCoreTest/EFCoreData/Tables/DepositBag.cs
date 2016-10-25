using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DepositBag
    {
        public DepositBag()
        {
            DepositBagDetail = new HashSet<DepositBagDetail>();
        }

        public int DepositBagKey { get; set; }
        public int? DepositChkKey { get; set; }
        public short Location { get; set; }
        public string DbBagNum { get; set; }
        public string DbEnteredBy { get; set; }
        public DateTime DbDateEntered { get; set; }
        public int TransDetailKey { get; set; }
        public bool DbReversed { get; set; }
        public bool DbMiddayDeposit { get; set; }
        public int? DbReverseTransDetailKey { get; set; }
        public decimal CashedChkTotalAmt { get; set; }
        public int CashedChkCount { get; set; }
        public decimal PaydayChkTotalAmt { get; set; }
        public int PaydayChkCount { get; set; }
        public decimal UsdCashedChkTotalAmt { get; set; }
        public int UsdCashedChkCount { get; set; }
        public decimal? ChkTotalAmt { get; set; }
        public int? ChkCount { get; set; }
        public bool IsElectronicBag { get; set; }

        public virtual ICollection<DepositBagDetail> DepositBagDetail { get; set; }
        public virtual TransDetail DbReverseTransDetailKeyNavigation { get; set; }
        public virtual DepositChk DepositChkKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
    }
}
