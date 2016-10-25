using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallInvalidPhoneNumber
    {
        public int WebCallInvalidPhoneNumberKey { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? InvalidUntil { get; set; }
        public DateTime DateEntered { get; set; }
    }
}
