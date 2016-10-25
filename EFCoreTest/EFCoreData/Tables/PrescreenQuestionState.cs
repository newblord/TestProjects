using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PrescreenQuestionState
    {
        public int PrescreenQuestionStateKey { get; set; }
        public int PrescreenQuestionKey { get; set; }
        public string StateAbbreviation { get; set; }

        public virtual PrescreenQuestion PrescreenQuestionKeyNavigation { get; set; }
        public virtual GlobalStates StateAbbreviationNavigation { get; set; }
    }
}
