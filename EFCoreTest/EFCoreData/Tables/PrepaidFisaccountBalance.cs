using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PrepaidFisaccountBalance
    {
        public int AccountBalanceKey { get; set; }
        public int? CustomerKey { get; set; }
        public short? ProcessStatus { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int? IssuerClientId { get; set; }
        public string ClientName { get; set; }
        public int? BinNum { get; set; }
        public string BankName { get; set; }
        public string PrimeAcctNum { get; set; }
        public decimal? OpeningBal { get; set; }
        public decimal? TotValLoadAmt { get; set; }
        public int? TotValLoadCnt { get; set; }
        public decimal? TotPurchaseAmt { get; set; }
        public int? TotPurchaseCnt { get; set; }
        public decimal? TotOtcAmt { get; set; }
        public int? TotOtcCnt { get; set; }
        public decimal? TotAtmWdAmt { get; set; }
        public int? TotAtmWdCnt { get; set; }
        public decimal? TotRtnAmt { get; set; }
        public int? TotRtnCnt { get; set; }
        public decimal? TotAdjAmt { get; set; }
        public int? TotAdjCnt { get; set; }
        public decimal? TotFeeAmt { get; set; }
        public int? TotFeeCnt { get; set; }
        public decimal? OthCrAmt { get; set; }
        public int? OthCrCnt { get; set; }
        public decimal? OthDbAmt { get; set; }
        public int? OthDbCnt { get; set; }
        public decimal? TotCrAmt { get; set; }
        public int? TotCreCnt { get; set; }
        public decimal? TotDbAmt { get; set; }
        public int? TotDbCnt { get; set; }
        public decimal? TotTransAmt { get; set; }
        public int? TotTransCnt { get; set; }
        public decimal? ClosingBalance { get; set; }
        public string BinCurrAlpha { get; set; }
        public string BinCurrCode { get; set; }
        public string PanProxyNum { get; set; }
        public int? PersonId { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
