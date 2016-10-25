using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class TransDetailIntShort
    {
        public int TransDetailIntShort1 { get; set; }
        public int TransDetailKey { get; set; }
        public int? CustomerKey { get; set; }
        public DateTime? BusinessDate { get; set; }
        public string TdDescription { get; set; }
        public string SpellTransCode { get; set; }
    }
}
