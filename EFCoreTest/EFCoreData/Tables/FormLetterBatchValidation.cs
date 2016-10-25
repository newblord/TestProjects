using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class FormLetterBatchValidation
    {
        public int FormLetterBatchValidationKey { get; set; }
        public int FormLetterBatchKey { get; set; }
        public int FormLetterKey { get; set; }
        public string FormLetterName { get; set; }
        public int UploadCount { get; set; }
        public int ReceiveCount { get; set; }
        public DateTime DateTimeEntered { get; set; }
    }
}
