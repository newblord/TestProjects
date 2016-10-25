using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebRemoteControl
    {
        public int WebRemoteControlKey { get; set; }
        public string Teller { get; set; }
        public string TellerEmail { get; set; }
        public string SessionGuid { get; set; }
        public DateTime DateEntered { get; set; }
        public string CustomerUrl { get; set; }
        public DateTime? DateEnded { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GoToAssistSessionId { get; set; }
    }
}
