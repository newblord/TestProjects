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
    
    public partial class CashedCheckPayment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CashedCheckPayment()
        {
            this.AttorneyPayments = new HashSet<AttorneyPayment>();
            this.CashedCheckPaymentRefunds = new HashSet<CashedCheckPaymentRefund>();
            this.CashedCheckPaymentRefundXRefs = new HashSet<CashedCheckPaymentRefundXRef>();
            this.CashedCheckPaymentRefundXRefs1 = new HashSet<CashedCheckPaymentRefundXRef>();
        }
    
        public int CASHED_CHECK_PAYMENT_KEY { get; set; }
        public int CASHED_CHECK_KEY { get; set; }
        public int TRANS_DETAIL_KEY { get; set; }
        public short LOCATION { get; set; }
        public string TELLER { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string NOTE { get; set; }
        public decimal PAID_AMT { get; set; }
        public bool REVERSED { get; set; }
        public Nullable<System.DateTime> REVERSED_DATE { get; set; }
        public short PAYMENT_METHOD { get; set; }
        public byte TRANS_CODE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttorneyPayment> AttorneyPayments { get; set; }
        public virtual CashedCheck CashedCheck { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CashedCheckPaymentRefund> CashedCheckPaymentRefunds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CashedCheckPaymentRefundXRef> CashedCheckPaymentRefundXRefs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CashedCheckPaymentRefundXRef> CashedCheckPaymentRefundXRefs1 { get; set; }
    }
}