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
    
    public partial class InsurancePaymentBatch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InsurancePaymentBatch()
        {
            this.InsurancePayments = new HashSet<InsurancePayment>();
        }
    
        public int INSURANCE_PAYMENT_BATCH_KEY { get; set; }
        public string INSURANCE_FILE_NAME { get; set; }
        public short PROCESSED_CNT { get; set; }
        public short ERROR_CNT { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string ENTERED_BY { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InsurancePayment> InsurancePayments { get; set; }
    }
}