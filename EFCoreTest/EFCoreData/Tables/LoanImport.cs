using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanImport
    {
        public int LoanImportKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public string CompanyName { get; set; }
        public string CustomerImportFile { get; set; }
        public string LoanImportFile { get; set; }
    }
}
