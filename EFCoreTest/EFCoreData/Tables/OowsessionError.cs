using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OowsessionError
    {
        public int OowSessionErrorKey { get; set; }
        public int OowSessionKey { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorText { get; set; }
        public DateTime DateEntered { get; set; }

        public virtual Oowsession OowSessionKeyNavigation { get; set; }
    }
}
