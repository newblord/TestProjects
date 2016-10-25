using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Ddisend
    {
        public Ddisend()
        {
            DdisendDetail = new HashSet<DdisendDetail>();
        }

        public int DdiSendKey { get; set; }
        public DateTime SentDate { get; set; }
        public string FileName { get; set; }

        public virtual ICollection<DdisendDetail> DdisendDetail { get; set; }
    }
}
