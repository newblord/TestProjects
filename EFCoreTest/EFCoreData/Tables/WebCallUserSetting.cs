using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallUserSetting
    {
        public int WebCallUserSettingKey { get; set; }
        public string User { get; set; }
        public string Setting { get; set; }
        public string Value { get; set; }
    }
}
