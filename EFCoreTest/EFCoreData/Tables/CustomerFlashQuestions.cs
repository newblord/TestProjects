using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerFlashQuestions
    {
        public byte CustomerFlashQuestionsKey { get; set; }
        public string LookupCode { get; set; }
        public string Description { get; set; }
    }
}
