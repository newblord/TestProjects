using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class FormLetterLoanHistoryFile
    {
        public int FormLetterLoanHistoryFileKey { get; set; }
        public int FormLetterPrintedKey { get; set; }
        public int FormLetterBatchKey { get; set; }
        public string LoanHistoryFileName { get; set; }
        public string ZipFileName { get; set; }
        public bool Uploaded { get; set; }
    }
}
