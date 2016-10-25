using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class BankStatus
    {
        public BankStatus()
        {
            Issuer = new HashSet<Issuer>();
        }

        public int BankStatusId { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Issuer> Issuer { get; set; }
    }
}
