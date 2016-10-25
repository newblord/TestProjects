namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanPaymentRefundXRef")]
    public partial class LoanPaymentRefundXRef
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoanPaymentRefundXRef()
        {
            LoanPaymentMPayRefunds = new HashSet<LoanPaymentMPayRefund>();
            LoanPaymentOpenEndRefunds = new HashSet<LoanPaymentOpenEndRefund>();
            LoanPaymentSPayRefunds = new HashSet<LoanPaymentSPayRefund>();
        }

        [Key]
        public int LOAN_PAYMENT_REFUND_XREF_KEY { get; set; }

        public int REFUND_LOAN_PAYMENT_KEY { get; set; }

        public int REFUNDED_LOAN_PAYMENT_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal REFUND_AMOUNT { get; set; }

        public virtual LoanPayment LoanPayment { get; set; }

        public virtual LoanPayment LoanPayment1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanPaymentMPayRefund> LoanPaymentMPayRefunds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanPaymentOpenEndRefund> LoanPaymentOpenEndRefunds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanPaymentSPayRefund> LoanPaymentSPayRefunds { get; set; }
    }
}
