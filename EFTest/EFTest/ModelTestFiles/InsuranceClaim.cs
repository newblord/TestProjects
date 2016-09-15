namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InsuranceClaim")]
    public partial class InsuranceClaim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InsuranceClaim()
        {
            InsuranceClaimEdits = new HashSet<InsuranceClaimEdit>();
            InsuranceClaimStatus = new HashSet<InsuranceClaimStatu>();
            InsurancePayments = new HashSet<InsurancePayment>();
            LoanPaymentInsuranceClaimXRefs = new HashSet<LoanPaymentInsuranceClaimXRef>();
        }

        [Key]
        public int INSURANCE_CLAIM_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public int INSURANCE_STATUS_KEY { get; set; }

        [Required]
        [StringLength(25)]
        public string CLAIM_NUM { get; set; }

        [Required]
        [StringLength(2000)]
        public string CLAIM_NOTE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FOLLOW_UP_DATE { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public DateTime? DATE_UPDATED { get; set; }

        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        public short CLAIM_REASON_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime SUBMITTED_DATE { get; set; }

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
