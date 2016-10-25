using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerMergeHistory
    {
        public int CustomerMergeHistoryKey { get; set; }
        public int DeletedCustPkey { get; set; }
        public int MergedIntoCustPkey { get; set; }
        public DateTime DateEnteredWithSeconds { get; set; }
        public string Teller { get; set; }
    }
}
