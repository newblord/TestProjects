using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AppConfig
    {
        public AppConfig()
        {
            AppValue = new HashSet<AppValue>();
        }

        public short AppConfigKey { get; set; }
        public string AppConfigName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AppValue> AppValue { get; set; }
    }
}
