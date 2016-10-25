using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DocTemplate
    {
        public int DoctemplateKey { get; set; }
        public string DocData { get; set; }
        public string DocName { get; set; }
        public DateTime DateEntered { get; set; }
        public string DocFormat { get; set; }
    }
}
