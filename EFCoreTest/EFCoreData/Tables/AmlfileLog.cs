using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AmlfileLog
    {
        public int AmlLogId { get; set; }
        public int SequenceNumber { get; set; }
        public string Stream { get; set; }
        public string Step { get; set; }
        public string FileName { get; set; }
        public int? NumberOfRecords { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }

        public virtual Tellerid TellerNavigation { get; set; }
    }
}
