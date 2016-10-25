using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class GoldTransStoneDetail
    {
        public int GoldTransStoneDetailKey { get; set; }
        public int GoldTransDetailKey { get; set; }
        public byte StoneType { get; set; }
        public decimal StoneSize { get; set; }
        public byte StoneCount { get; set; }

        public virtual GoldTransDetail GoldTransDetailKeyNavigation { get; set; }
    }
}
