using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class FormLetterReplacesXref
    {
        public int FormLetterKey { get; set; }
        public int DeletedFormLetterKey { get; set; }

        public virtual FormLetter DeletedFormLetterKeyNavigation { get; set; }
        public virtual FormLetter FormLetterKeyNavigation { get; set; }
    }
}
