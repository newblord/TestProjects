using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AppValue
    {
        public short AppValueKey { get; set; }
        public short AppConfigKey { get; set; }
        public short AppSettingKey { get; set; }
        public string AppValue1 { get; set; }
        public DateTime LastUpdated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual AppConfig AppConfigKeyNavigation { get; set; }
        public virtual AppSetting AppSettingKeyNavigation { get; set; }
    }
}
