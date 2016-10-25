using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanImportXref
    {
        public int LoanImportKey { get; set; }
        public int LoanKey { get; set; }
        public string ImportLocation { get; set; }
    }
}
