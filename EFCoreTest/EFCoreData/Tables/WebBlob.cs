using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebBlob
    {
        public WebBlob()
        {
            WebBlobLoanApplicationXref = new HashSet<WebBlobLoanApplicationXref>();
            WebBlobLoanXref = new HashSet<WebBlobLoanXref>();
            WebBlobVisitorEmailXref = new HashSet<WebBlobVisitorEmailXref>();
        }

        public int WebBlobKey { get; set; }
        public byte[] Data { get; set; }
        public short WebBlobTypeKey { get; set; }
        public DateTime DateEntered { get; set; }

        public virtual ICollection<WebBlobLoanApplicationXref> WebBlobLoanApplicationXref { get; set; }
        public virtual ICollection<WebBlobLoanXref> WebBlobLoanXref { get; set; }
        public virtual ICollection<WebBlobVisitorEmailXref> WebBlobVisitorEmailXref { get; set; }
        public virtual WebBlobType WebBlobTypeKeyNavigation { get; set; }
    }
}
