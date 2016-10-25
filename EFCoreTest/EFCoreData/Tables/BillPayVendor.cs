using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class BillPayVendor
    {
        public BillPayVendor()
        {
            BillPayBiller = new HashSet<BillPayBiller>();
        }

        public int BillpayVendorKey { get; set; }
        public string VendorName { get; set; }
        public byte VendorId { get; set; }
        public string Phone { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string DeletedBy { get; set; }

        public virtual ICollection<BillPayBiller> BillPayBiller { get; set; }
    }
}
