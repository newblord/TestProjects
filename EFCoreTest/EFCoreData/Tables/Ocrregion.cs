using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Ocrregion
    {
        public Ocrregion()
        {
            BillerOcrregion = new HashSet<BillerOcrregion>();
        }

        public int OcrregionKey { get; set; }
        public byte Snippet { get; set; }
        public bool Enable { get; set; }
        public bool Front { get; set; }
        public bool Millimeters { get; set; }
        public short X { get; set; }
        public short Y { get; set; }
        public short Width { get; set; }
        public short Height { get; set; }
        public byte Orientation { get; set; }
        public byte Color { get; set; }
        public byte Side { get; set; }
        public short Ocrflags { get; set; }
        public byte Compression { get; set; }

        public virtual ICollection<BillerOcrregion> BillerOcrregion { get; set; }
    }
}
