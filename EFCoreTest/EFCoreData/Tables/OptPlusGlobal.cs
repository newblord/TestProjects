using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OptPlusGlobal
    {
        public int OptplusGlobalKey { get; set; }
        public short OdNumLastDirectDeposits { get; set; }
        public decimal OdPercentOfDepositAvg { get; set; }
        public decimal OdMaxAmtRecv { get; set; }
        public decimal OdMinDirectDepositAmt { get; set; }
        public decimal OdNonDdpMaxAmtToRecv { get; set; }
        public short MaxDaysNegCardBalance { get; set; }
        public short NumDaysAfterDdpForRi { get; set; }
        public decimal MaxAmountPerLoad { get; set; }
        public decimal MaxAmountLostCardBalance { get; set; }
        public string ReversalCutoffTime { get; set; }
        public decimal MaxAmountPerUnload { get; set; }
        public decimal MinAmountPerLoad { get; set; }
        public bool IsEnableDirectDepositOdp { get; set; }
        public bool IsEnableNondirectDepositOdp { get; set; }
        public short OdNonDdpNumGoodLoans { get; set; }
        public decimal MaxBalance { get; set; }
        public byte MaxLoadsPerDay { get; set; }
        public byte MaxUnloadsPerDay { get; set; }
        public decimal MaxLoadAmountPerDay { get; set; }
        public decimal MaxAtmUnloadAmountPerDay { get; set; }
        public decimal MaxOtherUnloadAmountPerDay { get; set; }
        public int PrepaidCardBinKey { get; set; }

        public virtual PrepaidCardBin PrepaidCardBinKeyNavigation { get; set; }
    }
}
