//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF6EdmxData
{
    using System;
    using System.Collections.Generic;
    
    public partial class BillPayBiller
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BillPayBiller()
        {
            this.BillerOCRRegions = new HashSet<BillerOCRRegion>();
        }
    
        public int BILLPAY_BILLER_KEY { get; set; }
        public byte VENDOR_ID { get; set; }
        public string DISPLAYED_NAME { get; set; }
        public string BILLER_CODE { get; set; }
        public string BILLER_NAME { get; set; }
        public string BILLER_PHONE { get; set; }
        public string RAW_IMPORTED_DATA { get; set; }
        public decimal MAX_ALLOWED_PAYMENT { get; set; }
        public byte STATUS { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string TELLER { get; set; }
        public Nullable<decimal> BILLER_FEE { get; set; }
        public Nullable<bool> USE_BILLER_FEE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillerOCRRegion> BillerOCRRegions { get; set; }
    }
}