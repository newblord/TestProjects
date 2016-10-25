using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OptPlusExportInitGl
    {
        public int OptPlusExportInitGlKey { get; set; }
        public string OptPlusTransCode { get; set; }
        public string TrecsTransCode { get; set; }
        public int D2je1dPos { get; set; }
        public int D2je1cPos { get; set; }
        public int D2je2dPos { get; set; }
        public int D2je2cPos { get; set; }
        public int D2je1dNeg { get; set; }
        public int D2je1cNeg { get; set; }
        public int D2je2dNeg { get; set; }
        public int D2je2cNeg { get; set; }
        public int PrepaidCardBinKey { get; set; }

        public virtual PrepaidCardBin PrepaidCardBinKeyNavigation { get; set; }
    }
}
