using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OowsessionAlert
    {
        public int OowSessionAlertKey { get; set; }
        public int OowSessionKey { get; set; }
        public string AlertCode { get; set; }
        public string AlertText { get; set; }
        public DateTime DateEntered { get; set; }

        public virtual Oowsession OowSessionKeyNavigation { get; set; }
    }
}
