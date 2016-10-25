using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ReturnCheckDetail
    {
        public ReturnCheckDetail()
        {
            ReturnCheckMatch = new HashSet<ReturnCheckMatch>();
        }

        public int ReturnCheckDetailKey { get; set; }
        public int ReturnCheckFileKey { get; set; }
        public string BankId { get; set; }
        public string AcctNo { get; set; }
        public decimal ChargebackAmt { get; set; }
        public string CustomerNumber { get; set; }
        public string CustomerName { get; set; }
        public int CurrencyKey { get; set; }
        public DateTime OriginalDepositDate { get; set; }
        public string ParsedLocation { get; set; }
        public string SequenceNumber { get; set; }
        public string ReturnReasonCode { get; set; }

        public virtual ICollection<ReturnCheckMatch> ReturnCheckMatch { get; set; }
        public virtual ReturnCheckFile ReturnCheckFileKeyNavigation { get; set; }
    }
}
