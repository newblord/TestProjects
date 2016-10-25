using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerDocument
    {
        public int CustomerDocumentKey { get; set; }
        public int CustomerKey { get; set; }
        public short Location { get; set; }
        public int Dwdocid { get; set; }
        public byte DocumentType { get; set; }
        public DateTime DateEntered { get; set; }
        public string IgnoreTeller { get; set; }
        public DateTime? IgnoreDate { get; set; }
        public string IgnoreType { get; set; }
        public string Teller { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
    }
}
