using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class EsignLoanStatus
    {
        public EsignLoanStatus()
        {
            EsignLoan = new HashSet<EsignLoan>();
        }

        public byte EsignStatusKey { get; set; }
        public string Description { get; set; }

        public virtual ICollection<EsignLoan> EsignLoan { get; set; }
    }
}
