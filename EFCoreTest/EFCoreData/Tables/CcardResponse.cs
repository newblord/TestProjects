using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CcardResponse
    {
        public int CcardResponseKey { get; set; }
        public int CustomerKey { get; set; }
        public DateTime ResponseDate { get; set; }
        public byte Response { get; set; }
        public string Teller { get; set; }
        public short Location { get; set; }
        public string ProductType { get; set; }
        public string LoanType { get; set; }
        public bool NewExist { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
