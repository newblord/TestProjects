using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class FormLetterBatchVendorFile
    {
        public int FormLetterBatchBuildVendorFileKey { get; set; }
        public int FormLetterBatchKey { get; set; }
        public int FormLetterKey { get; set; }
        public string FileName { get; set; }
        public bool Uploaded { get; set; }
    }
}
