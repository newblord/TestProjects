using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DocPrint
    {
        public int DocprintKey { get; set; }
        public int DoctemplateKey { get; set; }
        public int? CustomerKey { get; set; }
        public int Location { get; set; }
        public string Teller { get; set; }
        public string DocData { get; set; }
        public DateTime DateEntered { get; set; }
        public int? TransDetailKey { get; set; }
        public int? LoanKey { get; set; }
        public int? CashedCheckKey { get; set; }
    }
}
