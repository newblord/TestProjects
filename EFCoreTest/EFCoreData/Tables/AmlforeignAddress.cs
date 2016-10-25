using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AmlforeignAddress
    {
        public int AmlForeignAddressKey { get; set; }
        public int? CustomerKey { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public int CountryKey { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }

        public virtual Country CountryKeyNavigation { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
