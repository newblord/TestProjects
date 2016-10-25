using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebImage
    {
        public int WebImageKey { get; set; }
        public int LoanApplicationKey { get; set; }
        public byte[] Data { get; set; }
        public string SourceUrl { get; set; }
        public string SourceHtml { get; set; }
        public DateTime DateEntered { get; set; }

        public virtual LoanApplication LoanApplicationKeyNavigation { get; set; }
    }
}
