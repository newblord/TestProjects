using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DdisendDetail
    {
        public int DdiSendDetailKey { get; set; }
        public int DdiSendKey { get; set; }
        public int DdiKey { get; set; }
        public string SortCode { get; set; }
        public string AccountNumber { get; set; }
        public string LastName { get; set; }
        public string Reference { get; set; }
        public string TransCode { get; set; }
        public DateTime SentDate { get; set; }
        public string Status { get; set; }
        public string Originator { get; set; }
        public string SentBy { get; set; }

        public virtual Ddi DdiKeyNavigation { get; set; }
        public virtual Ddisend DdiSendKeyNavigation { get; set; }
    }
}
