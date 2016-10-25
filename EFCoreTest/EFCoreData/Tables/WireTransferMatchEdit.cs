﻿using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WireTransferMatchEdit
    {
        public int WireTransferMatchEditKey { get; set; }
        public int WireTransferMatchKey { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }

        public virtual WireTransferMatch WireTransferMatchKeyNavigation { get; set; }
    }
}
