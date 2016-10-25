using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class BillPayBiller
    {
        public BillPayBiller()
        {
            BillerOcrregion = new HashSet<BillerOcrregion>();
        }

        public int BillpayBillerKey { get; set; }
        public byte VendorId { get; set; }
        public string DisplayedName { get; set; }
        public string BillerCode { get; set; }
        public string BillerName { get; set; }
        public string BillerPhone { get; set; }
        public string RawImportedData { get; set; }
        public decimal MaxAllowedPayment { get; set; }
        public byte Status { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public decimal? BillerFee { get; set; }
        public bool? UseBillerFee { get; set; }

        public virtual ICollection<BillerOcrregion> BillerOcrregion { get; set; }
        public virtual BillPayVendor Vendor { get; set; }
    }
}
