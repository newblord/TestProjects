using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class FormLetterLocation
    {
        public int FormLetterKey { get; set; }
        public short Location { get; set; }

        public virtual FormLetter FormLetterKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
    }
}
