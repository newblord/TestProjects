using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ParseCash
    {
        public ParseCash()
        {
            TransDetailCash = new HashSet<TransDetailCash>();
            VaultCountCalcParseCashKeyNavigation = new HashSet<VaultCount>();
            VaultCountEnteredParseCashKeyNavigation = new HashSet<VaultCount>();
        }

        public int ParseCashKey { get; set; }
        public decimal Pc100 { get; set; }
        public decimal Pc50 { get; set; }
        public decimal Pc20 { get; set; }
        public decimal Pc10 { get; set; }
        public decimal Pc05 { get; set; }
        public decimal Pc01 { get; set; }
        public decimal PcRollHlf { get; set; }
        public decimal PcRollQtr { get; set; }
        public decimal PcRollDime { get; set; }
        public decimal PcRollNic { get; set; }
        public decimal PcRollPen { get; set; }
        public decimal PcLooseHlf { get; set; }
        public decimal PcLooseQtr { get; set; }
        public decimal PcLooseDime { get; set; }
        public decimal PcLooseNic { get; set; }
        public decimal PcLoosePen { get; set; }
        public decimal PcMisc { get; set; }
        public decimal PcRoll02 { get; set; }
        public decimal PcRoll01 { get; set; }
        public decimal PcRoll2p { get; set; }
        public decimal PcRoll20p { get; set; }
        public decimal PcLoose01 { get; set; }
        public decimal PcLoose02 { get; set; }
        public decimal PcLoose2p { get; set; }
        public decimal PcLoose20p { get; set; }
        public decimal? PcTotCash { get; set; }

        public virtual ICollection<TransDetailCash> TransDetailCash { get; set; }
        public virtual ICollection<VaultCount> VaultCountCalcParseCashKeyNavigation { get; set; }
        public virtual ICollection<VaultCount> VaultCountEnteredParseCashKeyNavigation { get; set; }
    }
}
