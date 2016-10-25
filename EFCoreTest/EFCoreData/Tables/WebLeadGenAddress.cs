using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebLeadGenAddress
    {
        public int WebLeadGenAddressKey { get; set; }
        public int WebLeadGenKey { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FaxNumber { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }

        public virtual WebLeadGen WebLeadGenKeyNavigation { get; set; }
    }
}
