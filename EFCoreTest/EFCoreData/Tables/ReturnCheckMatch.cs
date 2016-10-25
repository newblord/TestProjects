using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ReturnCheckMatch
    {
        public int ReturnCheckMatchKey { get; set; }
        public int ReturnCheckDetailKey { get; set; }
        public int? LoanKey { get; set; }
        public int? CashedCheckKey { get; set; }

        public virtual ReturnCheckDetail ReturnCheckDetailKeyNavigation { get; set; }
    }
}
