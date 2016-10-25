using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class FormLetterAfterLetterXref
    {
        public int FormLetterKey { get; set; }
        public int AfterFormLetterKey { get; set; }

        public virtual FormLetter AfterFormLetterKeyNavigation { get; set; }
        public virtual FormLetter FormLetterKeyNavigation { get; set; }
    }
}
