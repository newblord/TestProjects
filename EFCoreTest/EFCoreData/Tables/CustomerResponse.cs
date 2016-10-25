using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerResponse
    {
        public int CustomerResponseKey { get; set; }
        public int? CustomerKey { get; set; }
        public int? VisitorKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public short Location { get; set; }
        public string Response { get; set; }
    }
}
