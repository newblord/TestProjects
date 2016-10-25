using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerLastCreditReport
    {
        public int CustomerLastCreditReportKey { get; set; }
        public int CustomerKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Ssn { get; set; }
        public DateTime? Dob { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
