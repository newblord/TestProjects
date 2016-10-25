using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class EmailDisposition
    {
        public EmailDisposition()
        {
            VisitorEmailDisposition = new HashSet<VisitorEmailDisposition>();
        }

        public int EmailDispositionKey { get; set; }
        public string Disposition { get; set; }

        public virtual ICollection<VisitorEmailDisposition> VisitorEmailDisposition { get; set; }
    }
}
