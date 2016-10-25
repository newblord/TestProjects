using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebDialerPhoneLine
    {
        public int WebDialerPhoneLineKey { get; set; }
        public string Description { get; set; }
        public int LineNo { get; set; }
        public int ColorRgb { get; set; }
        public bool Enabled { get; set; }
        public string Phone { get; set; }
    }
}
