using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AchbankConfig
    {
        public AchbankConfig()
        {
            AchbankConfigException = new HashSet<AchbankConfigException>();
        }

        public int AchBankConfigKey { get; set; }
        public int AchBankKey { get; set; }
        public string Key { get; set; }
        public string DefaultValue { get; set; }
        public DateTime DateEntered { get; set; }

        public virtual ICollection<AchbankConfigException> AchbankConfigException { get; set; }
    }
}
