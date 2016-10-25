namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanPayment")]
    public partial class LoanPayment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoanPayment()
        {
            ACH_History = new HashSet<ACH_History>();
            ACH_History1 = new HashSet<ACH_History>();
            ACH_History2 = new HashSet<ACH_History>();
            AttorneyPayments = new HashSet<AttorneyPayment>();
            LoanFundings = new HashSet<LoanFunding>();
            LoanPaymentAddToQueues = new HashSet<LoanPaymentAddToQueue>();
            LoanPaymentDecreaseAmountOweds = new HashSet<LoanPaymentDecreaseAmountOwed>();
            LoanPaymentDueDates = new HashSet<LoanPaymentDueDate>();
            LoanPaymentInsuranceClaimXRefs = new HashSet<LoanPaymentInsuranceClaimXRef>();
            LoanPaymentMPays = new HashSet<LoanPaymentMPay>();
            LoanPaymentOpenEnds = new HashSet<LoanPaymentOpenEnd>();
            LoanPaymentRefundXRefs = new HashSet<LoanPaymentRefundXRef>();
            LoanPaymentRefundXRefs1 = new HashSet<LoanPaymentRefundXRef>();
            LoanPaymentRescinds = new HashSet<LoanPaymentRescind>();
            LoanPaymentRescinds1 = new HashSet<LoanPaymentRescind>();
            LoanPaymentSPays = new HashSet<LoanPaymentSPay>();
            LoanPaymentSuspendInterests = new HashSet<LoanPaymentSuspendInterest>();
            LoanPaymentSuspendInterests1 = new HashSet<LoanPaymentSuspendInterest>();
            LoanPaymentWaiveRIFees = new HashSet<LoanPaymentWaiveRIFee>();
            OpenEndLoanStatements = new HashSet<OpenEndLoanStatement>();
        }

        [Key]
        public int LOANPAYMENT_KEY { get; set; }

        public int PAID_LOAN_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(500)]
        public string NOTE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAID_AMT { get; set; }

        public bool REVERSED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? REVERSED_DATE { get; set; }

        public short PAYMENT_METHOD { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        public byte TRANS_CODE { get; set; }

        [Required]
        [StringLength(1)]
        public string PRODUCT_TYPE { get; set; }

        [Required]
        [StringLength(1)]
        public string LOAN_TYPE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int LOAN_KEY { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int LOAN_PAYMENT_KEY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACH_History> ACH_History { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACH_History> ACH_History1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACH_History> ACH_History2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttorneyPayment> AttorneyPayments { get; set; }

        public virtual Company Company { get; set; }

        public virtual Loan Loan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanFunding> LoanFundings { get; set; }

        public virtual TransDetail TransDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanPaymentAddToQueue> LoanPaymentAddToQueues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanPaymentDecreaseAmountOwed> LoanPaymentDecreaseAmountOweds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanPaymentDueDate> LoanPaymentDueDates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanPaymentInsuranceClaimXRef> LoanPaymentInsuranceClaimXRefs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanPaymentMPay> LoanPaymentMPays { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanPaymentOpenEnd> LoanPaymentOpenEnds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanPaymentRefundXRef> LoanPaymentRefundXRefs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanPaymentRefundXRef> LoanPaymentRefundXRefs1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanPaymentRescind> LoanPaymentRescinds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanPaymentRescind> LoanPaymentRescinds1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanPaymentSPay> LoanPaymentSPays { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanPaymentSuspendInterest> LoanPaymentSuspendInterests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanPaymentSuspendInterest> LoanPaymentSuspendInterests1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanPaymentWaiveRIFee> LoanPaymentWaiveRIFees { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpenEndLoanStatement> OpenEndLoanStatements { get; set; }
    }
}
