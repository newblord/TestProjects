using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanDocUpload
    {
        public int LoanDocUploadKey { get; set; }
        public DateTime UploadDate { get; set; }
        public string Teller { get; set; }
        public short Location { get; set; }
        public int LoanKey { get; set; }
        public string LoanDocFileName { get; set; }
        public string ZipFileName { get; set; }
    }
}
