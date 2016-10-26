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
    
    public partial class InsuranceClaim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InsuranceClaim()
        {
            this.InsuranceClaimEdits = new HashSet<InsuranceClaimEdit>();
            this.InsuranceClaimStatus = new HashSet<InsuranceClaimStatu>();
            this.InsurancePayments = new HashSet<InsurancePayment>();
            this.LoanPaymentInsuranceClaimXRefs = new HashSet<LoanPaymentInsuranceClaimXRef>();
        }
    
        public int INSURANCE_CLAIM_KEY { get; set; }
        public int LOAN_KEY { get; set; }
        public int INSURANCE_STATUS_KEY { get; set; }
        public string CLAIM_NUM { get; set; }
        public string CLAIM_NOTE { get; set; }
        public Nullable<System.DateTime> FOLLOW_UP_DATE { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string ENTERED_BY { get; set; }
        public Nullable<System.DateTime> DATE_UPDATED { get; set; }
        public string UPDATED_BY { get; set; }
        public short CLAIM_REASON_ID { get; set; }
        public System.DateTime SUBMITTED_DATE { get; set; }
    
        public virtual InsuranceStatu InsuranceStatu { get; set; }
        public virtual Loan Loan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InsuranceClaimEdit> InsuranceClaimEdits { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InsuranceClaimStatu> InsuranceClaimStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InsurancePayment> InsurancePayments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanPaymentInsuranceClaimXRef> LoanPaymentInsuranceClaimXRefs { get; set; }
    }
}