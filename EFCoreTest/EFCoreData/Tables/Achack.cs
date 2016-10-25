using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Achack
    {
        public int AchAckKey { get; set; }
        public int AchSentKey { get; set; }
        public string FileName { get; set; }
        public bool FileRejected { get; set; }
        public int RejectItemCount { get; set; }
        public decimal RejectCreditAmt { get; set; }
        public int TotalItemCount { get; set; }
        public decimal TotalCreditAmt { get; set; }
        public DateTime DateEntered { get; set; }
    }
}
