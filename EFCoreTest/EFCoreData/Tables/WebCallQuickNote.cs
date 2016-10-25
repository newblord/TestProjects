using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallQuickNote
    {
        public int QuickNoteKey { get; set; }
        public short AssignedPosition { get; set; }
        public string Note { get; set; }
        public string ButtonText { get; set; }
        public int ButtonBackgroundColor { get; set; }
        public int ButtonForegroundColor { get; set; }
    }
}
