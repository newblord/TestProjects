using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class IdentificationTypeVerify
    {
        public IdentificationTypeVerify()
        {
            CustomerIdentification = new HashSet<CustomerIdentification>();
            LoanApplication = new HashSet<LoanApplication>();
        }

        public string VerifyCode { get; set; }
        public string IdVerifyDescription { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public int IdentificationTypeVerifyKey { get; set; }

        public virtual ICollection<CustomerIdentification> CustomerIdentification { get; set; }
        public virtual ICollection<LoanApplication> LoanApplication { get; set; }
    }
}
