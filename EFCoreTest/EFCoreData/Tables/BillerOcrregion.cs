using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class BillerOcrregion
    {
        public int BillerOcrregionKey { get; set; }
        public int BillpayBillerKey { get; set; }
        public int OcrregionKey { get; set; }
        public int Scanlinelength { get; set; }
        public byte? AccountNumStart { get; set; }
        public byte? AccountNumLength { get; set; }
        public byte? AmountStart { get; set; }
        public byte? AmountLength { get; set; }
        public bool? TrimAccountNumLeadingZeros { get; set; }

        public virtual BillPayBiller BillpayBillerKeyNavigation { get; set; }
        public virtual Ocrregion OcrregionKeyNavigation { get; set; }
    }
}
