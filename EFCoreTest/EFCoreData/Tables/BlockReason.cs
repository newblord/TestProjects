using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class BlockReason
    {
        public BlockReason()
        {
            CreditCardBlock = new HashSet<CreditCardBlock>();
            Issuer = new HashSet<Issuer>();
            Visitor = new HashSet<Visitor>();
        }

        public int BlockReasonKey { get; set; }
        public string ReasonDescription { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<CreditCardBlock> CreditCardBlock { get; set; }
        public virtual ICollection<Issuer> Issuer { get; set; }
        public virtual ICollection<Visitor> Visitor { get; set; }
    }
}
