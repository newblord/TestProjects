using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CuroHelp
    {
        public int CurohelpKey { get; set; }
        public string FormName { get; set; }
        public string ControlName { get; set; }
        public string HelpTitle { get; set; }
        public string HelpText { get; set; }
        public string TooltipText { get; set; }
    }
}
