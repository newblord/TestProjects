using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class VisitorEmailDisposition
    {
        public int VisitorEmailDispositionKey { get; set; }
        public int VisitorEmailKey { get; set; }
        public int EmailDispositionKey { get; set; }
        public DateTime DispositionDate { get; set; }
        public string Teller { get; set; }

        public virtual EmailDisposition EmailDispositionKeyNavigation { get; set; }
        public virtual VisitorEmail VisitorEmailKeyNavigation { get; set; }
    }
}
