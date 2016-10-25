using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CashedCheckImage
    {
        public int CashedCheckImageKey { get; set; }
        public int CashedCheckKey { get; set; }
        public byte[] Data { get; set; }
        public short ImageType { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime DateToDelete { get; set; }

        public virtual CashedCheck CashedCheckKeyNavigation { get; set; }
    }
}
