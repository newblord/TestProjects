using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class VaultMaster
    {
        public VaultMaster()
        {
            VaultMasterParsedCash = new HashSet<VaultMasterParsedCash>();
        }

        public int VaultKey { get; set; }
        public short Location { get; set; }
        public string VaultMgr { get; set; }
        public decimal? Vault100 { get; set; }
        public decimal? Vault50 { get; set; }
        public decimal? Vault20 { get; set; }
        public decimal? Vault10 { get; set; }
        public decimal? Vault05 { get; set; }
        public decimal? Vault01 { get; set; }
        public decimal? VaultHlf { get; set; }
        public decimal? VaultQtr { get; set; }
        public decimal? VaultDime { get; set; }
        public decimal? VaultNic { get; set; }
        public decimal? VaultPen { get; set; }
        public decimal? VaultMisc { get; set; }
        public decimal VaultCashchkAmt { get; set; }
        public decimal? VaultCcardAmt { get; set; }
        public short VaultCashchkCnt { get; set; }
        public short? VaultCcardCnt { get; set; }
        public bool MgrAuditComplete { get; set; }
        public bool VmgrAuditComplete { get; set; }
        public decimal VaultMpayPaydayAmt { get; set; }
        public decimal VaultOendPaydayAmt { get; set; }
        public decimal VaultSpayTitleAmt { get; set; }
        public decimal VaultMpayTitleAmt { get; set; }
        public decimal VaultOendTitleAmt { get; set; }
        public decimal VaultSpayTitle2ndAmt { get; set; }
        public decimal VaultMpayTitle2ndAmt { get; set; }
        public decimal VaultOendTitle2ndAmt { get; set; }
        public decimal VaultSpaySigAmt { get; set; }
        public decimal VaultMpaySigAmt { get; set; }
        public decimal VaultOendSigAmt { get; set; }
        public short VaultMpayPaydayCnt { get; set; }
        public short VaultOendPaydayCnt { get; set; }
        public short VaultSpayTitleCnt { get; set; }
        public short VaultMpayTitleCnt { get; set; }
        public short VaultOendTitleCnt { get; set; }
        public short VaultSpayTitle2ndCnt { get; set; }
        public short VaultMpayTitle2ndCnt { get; set; }
        public short VaultOendTitle2ndCnt { get; set; }
        public short VaultSpaySigCnt { get; set; }
        public short VaultMpaySigCnt { get; set; }
        public short VaultOendSigCnt { get; set; }
        public short VaultBagMiddayCnt { get; set; }
        public short VaultBagMiddayChkCnt { get; set; }
        public decimal VaultBagMiddayAmt { get; set; }
        public short VaultBagEodayCnt { get; set; }
        public short VaultBagEodayChkCnt { get; set; }
        public decimal VaultBagEodayAmt { get; set; }
        public decimal VaultSpayPaydayChecksAmt { get; set; }
        public short VaultSpayPaydayChecksCnt { get; set; }
        public decimal VaultSpayPaydayDebitCardsAmt { get; set; }
        public int VaultSpayPaydayDebitCardsCnt { get; set; }
        public short VaultGoldDailyBagsCnt { get; set; }
        public decimal VaultGoldDailyBagsAmt { get; set; }
        public decimal? Vault2p { get; set; }
        public decimal? Vault20p { get; set; }
        public decimal? Vault02 { get; set; }
        public decimal? VaultTotCash { get; set; }

        public virtual ICollection<VaultMasterParsedCash> VaultMasterParsedCash { get; set; }
    }
}
