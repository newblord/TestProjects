using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebLeadGenTranslations
    {
        public int WebLeadGenKey { get; set; }
        public string Value { get; set; }
        public int Field { get; set; }
        public int Translation { get; set; }
        public int WebLeadGenTranslationsKey { get; set; }

        public virtual WebLeadGen WebLeadGenKeyNavigation { get; set; }
    }
}
