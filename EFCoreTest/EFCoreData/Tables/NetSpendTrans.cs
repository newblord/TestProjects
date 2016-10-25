using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class NetSpendTrans
    {
        public int NetSpendTransKey { get; set; }
        public int? TransDetailKey { get; set; }
        public short ResultNum { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public string ResultStr { get; set; }
        public string CcardNum { get; set; }
    }
}
