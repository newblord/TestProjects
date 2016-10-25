using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class StoreClosed
    {
        public int StoreclosedKey { get; set; }
        public string Comment { get; set; }
        public bool Bank { get; set; }
        public DateTime Closedate { get; set; }
    }
}
