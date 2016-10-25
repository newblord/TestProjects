using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CcStatus
    {
        public short CcStatusKey { get; set; }
        public short StatusCode { get; set; }
        public string Description { get; set; }
    }
}
