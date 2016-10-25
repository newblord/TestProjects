using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CreditCardVendor
    {
        public CreditCardVendor()
        {
            CreditCardResultCode = new HashSet<CreditCardResultCode>();
            CreditCardTrans = new HashSet<CreditCardTrans>();
        }

        public byte CreditCardVendorKey { get; set; }
        public string CcVendorName { get; set; }

        public virtual ICollection<CreditCardResultCode> CreditCardResultCode { get; set; }
        public virtual ICollection<CreditCardTrans> CreditCardTrans { get; set; }
    }
}
