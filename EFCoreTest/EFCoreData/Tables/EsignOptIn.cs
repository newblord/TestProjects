using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class EsignOptIn
    {
        public int EsignOptInKey { get; set; }
        public int EsignOptInDocKey { get; set; }
        public DateTime DateEntered { get; set; }
        public short Location { get; set; }
    }
}
