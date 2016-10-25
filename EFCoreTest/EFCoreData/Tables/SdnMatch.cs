using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class SdnMatch
    {
        public int SdnMatchKey { get; set; }
        public string SdnName { get; set; }
        public string SdnType { get; set; }
        public string SdnProgram { get; set; }
        public string SdnTitle { get; set; }
        public string SdnRemarks { get; set; }
        public string AltType { get; set; }
        public string AltName { get; set; }
        public string AddAddress { get; set; }
        public string AddCity { get; set; }
        public string AddCountry { get; set; }
        public string AddRemarks { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public int? CustomerKey { get; set; }
        public int? SdnCertKey { get; set; }
    }
}
