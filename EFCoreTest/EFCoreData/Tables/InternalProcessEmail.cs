using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class InternalProcessEmail
    {
        public int InternalProcessEmailKey { get; set; }
        public string Recipients { get; set; }
        public string Subject { get; set; }
        public byte InternalProcessEmailTypeKey { get; set; }
        public bool Processed { get; set; }
    }
}
