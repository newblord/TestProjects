using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class GalileoResponseCode
    {
        public int GalileoResponseCodeKey { get; set; }
        public short Code { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
    }
}
