using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PrepaidCardBin
    {
        public PrepaidCardBin()
        {
            OptPlusBinProduct = new HashSet<OptPlusBinProduct>();
            OptPlusExportInitGl = new HashSet<OptPlusExportInitGl>();
            OptPlusGlobal = new HashSet<OptPlusGlobal>();
            PrepaidCardBinCompany = new HashSet<PrepaidCardBinCompany>();
        }

        public int PrepaidCardBinKey { get; set; }
        public string BinNumber { get; set; }
        public string BinDescription { get; set; }
        public byte CardBrand { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public DateTime? DateTerminated { get; set; }
        public byte CardType { get; set; }
        public string RoutingNo { get; set; }
        public byte IdVerifyMethod { get; set; }
        public string BinBankname { get; set; }
        public int? WsConfigKey { get; set; }

        public virtual ICollection<OptPlusBinProduct> OptPlusBinProduct { get; set; }
        public virtual ICollection<OptPlusExportInitGl> OptPlusExportInitGl { get; set; }
        public virtual ICollection<OptPlusGlobal> OptPlusGlobal { get; set; }
        public virtual ICollection<PrepaidCardBinCompany> PrepaidCardBinCompany { get; set; }
    }
}
