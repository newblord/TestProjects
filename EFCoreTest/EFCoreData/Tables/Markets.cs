using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Markets
    {
        public Markets()
        {
            Company = new HashSet<Company>();
        }

        public short MarketKey { get; set; }
        public string MarketDesc { get; set; }
        public int? LocaleSettingKey { get; set; }

        public virtual ICollection<Company> Company { get; set; }
    }
}
