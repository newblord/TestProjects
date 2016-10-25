using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class SecurityAnswer
    {
        public int SecurityAnswerKey { get; set; }
        public string Teller { get; set; }
        public int SecurityQuestionKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Answer { get; set; }

        public virtual SecurityQuestion SecurityQuestionKeyNavigation { get; set; }
        public virtual Tellerid TellerNavigation { get; set; }
    }
}
