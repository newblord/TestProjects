using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AppSetting
    {
        public AppSetting()
        {
            AppValue = new HashSet<AppValue>();
        }

        public short AppSettingKey { get; set; }
        public string AppSettingName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AppValue> AppValue { get; set; }
    }
}
