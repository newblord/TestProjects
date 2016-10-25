using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CheckPaymentType
    {
        public CheckPaymentType()
        {
            LoanPaymentCheckPaymentTypeXref = new HashSet<LoanPaymentCheckPaymentTypeXref>();
        }

        public int CheckPaymentTypeKey { get; set; }
        public string TypeDescription { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }

        public virtual ICollection<LoanPaymentCheckPaymentTypeXref> LoanPaymentCheckPaymentTypeXref { get; set; }
    }
}
