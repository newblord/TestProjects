using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AccumConfig
    {
        public int AccumConfigKey { get; set; }
        public string ShortDescr { get; set; }
        public string LongDescr { get; set; }
        public string TaskActionResultKeys { get; set; }
        public string AgentActionKeys { get; set; }
        public string Result1Keys { get; set; }
        public string Result2Keys { get; set; }
        public decimal AccumCost { get; set; }
        public bool ShowInRi { get; set; }
        public string ExcludeResults { get; set; }
    }
}
