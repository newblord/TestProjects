using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ImageCashLetterBundle
    {
        public ImageCashLetterBundle()
        {
            CashedCheck = new HashSet<CashedCheck>();
        }

        public int ImageCashLetterBundleKey { get; set; }
        public int ImageCashLetterDetailKey { get; set; }
        public short BundleSeq { get; set; }
        public int WsResponseKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }

        public virtual ICollection<CashedCheck> CashedCheck { get; set; }
        public virtual ImageCashLetterDetail ImageCashLetterDetailKeyNavigation { get; set; }
    }
}
