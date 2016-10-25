using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class VaultCount
    {
        public VaultCount()
        {
            CardBatchSettle = new HashSet<CardBatchSettle>();
            OverShort = new HashSet<OverShort>();
            VaultCountCalcParsedCash = new HashSet<VaultCountCalcParsedCash>();
            VaultCountEnteredParsedCash = new HashSet<VaultCountEnteredParsedCash>();
            VaultCountService = new HashSet<VaultCountService>();
        }

        public int VaultCountKey { get; set; }
        public int TransDetailKey { get; set; }
        public string Teller { get; set; }
        public short Location { get; set; }
        public DateTime DateEntered { get; set; }
        public byte StartOfDay { get; set; }
        public string OsReason { get; set; }
        public int? EnteredParseCashKey { get; set; }
        public int? CalcParseCashKey { get; set; }
        public decimal CashchkAmt { get; set; }
        public decimal CollchkAmt { get; set; }
        public int CashchkCnt { get; set; }
        public int CollchkCnt { get; set; }
        public decimal CcardAmt { get; set; }
        public int CcardCnt { get; set; }
        public int? BalsheetKey { get; set; }
        public string OsCategory { get; set; }
        public decimal SpayPaydayChecksAmt { get; set; }
        public decimal MpayPaydayAmt { get; set; }
        public decimal OendPaydayAmt { get; set; }
        public decimal SpayTitleAmt { get; set; }
        public decimal MpayTitleAmt { get; set; }
        public decimal OendTitleAmt { get; set; }
        public decimal SpayTitle2ndAmt { get; set; }
        public decimal MpayTitle2ndAmt { get; set; }
        public decimal OendTitle2ndAmt { get; set; }
        public decimal SpaySigAmt { get; set; }
        public decimal MpaySigAmt { get; set; }
        public decimal OendSigAmt { get; set; }
        public int SpayPaydayChecksCnt { get; set; }
        public int MpayPaydayCnt { get; set; }
        public int OendPaydayCnt { get; set; }
        public int SpayTitleCnt { get; set; }
        public int MpayTitleCnt { get; set; }
        public int OendTitleCnt { get; set; }
        public int SpayTitle2ndCnt { get; set; }
        public int MpayTitle2ndCnt { get; set; }
        public int OendTitle2ndCnt { get; set; }
        public int SpaySigCnt { get; set; }
        public int MpaySigCnt { get; set; }
        public int OendSigCnt { get; set; }
        public DateTime? BusinessDate { get; set; }
        public int BagMiddayCnt { get; set; }
        public int BagMiddayChkCnt { get; set; }
        public decimal BagMiddayAmt { get; set; }
        public int BagEodayCnt { get; set; }
        public int BagEodayChkCnt { get; set; }
        public decimal BagEodayAmt { get; set; }
        public decimal SpayPaydayDebitCardsAmt { get; set; }
        public int SpayPaydayDebitCardsCnt { get; set; }
        public int GoldDailyBagsCnt { get; set; }
        public decimal GoldDailyBagsAmt { get; set; }

        public virtual ICollection<CardBatchSettle> CardBatchSettle { get; set; }
        public virtual ICollection<OverShort> OverShort { get; set; }
        public virtual ICollection<VaultCountCalcParsedCash> VaultCountCalcParsedCash { get; set; }
        public virtual ICollection<VaultCountEnteredParsedCash> VaultCountEnteredParsedCash { get; set; }
        public virtual ICollection<VaultCountService> VaultCountService { get; set; }
        public virtual ParseCash CalcParseCashKeyNavigation { get; set; }
        public virtual ParseCash EnteredParseCashKeyNavigation { get; set; }
        public virtual Tellerid TellerNavigation { get; set; }
        public virtual TransDetail TransDetailKeyNavigation { get; set; }
    }
}
