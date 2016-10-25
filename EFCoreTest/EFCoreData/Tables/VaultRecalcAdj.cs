using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class VaultRecalcAdj
    {
        public int VaultRecalcAdjKey { get; set; }
        public short Location { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public string FieldName { get; set; }
        public decimal VaultAmt { get; set; }
        public int VaultCnt { get; set; }
        public decimal CalcAmt { get; set; }
        public int CalcCnt { get; set; }
        public decimal? AmtDiff { get; set; }
        public int? CntDiff { get; set; }
    }
}
