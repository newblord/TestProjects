﻿using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class IssuerEdit
    {
        public int IssuerEditKey { get; set; }
        public int IssuerKey { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }

        public virtual Issuer IssuerKeyNavigation { get; set; }
    }
}