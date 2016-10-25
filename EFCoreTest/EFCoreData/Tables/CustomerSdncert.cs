using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerSdncert
    {
        public int SdncertKey { get; set; }
        public int CustomerKey { get; set; }
        public bool DiffDob { get; set; }
        public DateTime? Dob { get; set; }
        public bool DiffAddress { get; set; }
        public bool DiffNumber { get; set; }
        public bool Other { get; set; }
        public string OtherDesc { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
    }
}
