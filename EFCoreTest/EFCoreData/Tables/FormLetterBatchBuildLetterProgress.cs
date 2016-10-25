using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class FormLetterBatchBuildLetterProgress
    {
        public int FormLetterBatchBuildLetterProgressKey { get; set; }
        public int FormLetterBatchKey { get; set; }
        public int FormLetterKey { get; set; }
        public bool BuildComplete { get; set; }
    }
}
