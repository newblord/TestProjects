using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AchbankConfigException
    {
        public int AchBankConfigExceptionKey { get; set; }
        public int AchBankConfigKey { get; set; }
        public short Loc { get; set; }
        public string Value { get; set; }
        public DateTime DateEntered { get; set; }

        public virtual AchbankConfig AchBankConfigKeyNavigation { get; set; }
        public virtual Company LocNavigation { get; set; }
    }
}
