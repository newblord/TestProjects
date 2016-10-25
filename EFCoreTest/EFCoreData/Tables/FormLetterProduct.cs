using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class FormLetterProduct
    {
        public int FormLetterKey { get; set; }
        public string ProductType { get; set; }
        public string LoanType { get; set; }
        public string LoanSubType { get; set; }

        public virtual FormLetter FormLetterKeyNavigation { get; set; }
    }
}
