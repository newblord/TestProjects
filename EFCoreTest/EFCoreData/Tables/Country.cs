using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Country
    {
        public Country()
        {
            AmladditionalParty = new HashSet<AmladditionalParty>();
            AmlforeignAddress = new HashSet<AmlforeignAddress>();
        }

        public int CountryKey { get; set; }
        public string CountryCode { get; set; }
        public string Description { get; set; }
        public int? CurrencyKey { get; set; }
        public bool IsEnabled { get; set; }
        public string Iso2CharCountryCode { get; set; }

        public virtual ICollection<AmladditionalParty> AmladditionalParty { get; set; }
        public virtual ICollection<AmlforeignAddress> AmlforeignAddress { get; set; }
        public virtual Currency CurrencyKeyNavigation { get; set; }
    }
}
