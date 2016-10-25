using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class InsurancePaymentBatch
    {
        public InsurancePaymentBatch()
        {
            InsurancePayment = new HashSet<InsurancePayment>();
        }

        public int InsurancePaymentBatchKey { get; set; }
        public string InsuranceFileName { get; set; }
        public short ProcessedCnt { get; set; }
        public short ErrorCnt { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }

        public virtual ICollection<InsurancePayment> InsurancePayment { get; set; }
    }
}
