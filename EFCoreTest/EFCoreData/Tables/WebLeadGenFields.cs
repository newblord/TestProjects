using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebLeadGenFields
    {
        public int WebLeadGenKey { get; set; }
        public int Field { get; set; }
        public string Name { get; set; }
        public int WebLeadGenFieldsKey { get; set; }

        public virtual WebLeadGen WebLeadGenKeyNavigation { get; set; }
    }
}
