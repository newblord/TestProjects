using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DocImage
    {
        public int DocimageKey { get; set; }
        public string DocData { get; set; }
        public string ImageName { get; set; }
        public DateTime DateEntered { get; set; }
        public string ImageType { get; set; }
        public string ImageFormat { get; set; }
    }
}
