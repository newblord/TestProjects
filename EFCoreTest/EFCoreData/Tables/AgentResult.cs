using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AgentResult
    {
        public int AgentResultKey { get; set; }
        public string LongDescr { get; set; }
        public string ShortDescr { get; set; }
        public byte ResultLevel { get; set; }
        public byte ScreenPop { get; set; }
    }
}
