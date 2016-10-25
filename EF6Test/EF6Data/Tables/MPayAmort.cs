namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MPayAmort")]
    public partial class MPayAmort
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MPayAmort()
        {
            MPayAmortDueDateChanges = new HashSet<MPayAmortDueDateChange>();
        }

        [Key]
        public int MPAY_AMORT_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public byte PAYMENT_NUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PAYMENT_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAYMENT_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CAB_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal DISCOUNT_AMT { get; set; }

        [Column(TypeName = "date")]
        public DateTime ADJUSTED_PAYMENT_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INSURANCE_FEE_AMT { get; set; }

        public virtual Loan Loan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MPayAmortDueDateChange> MPayAmortDueDateChanges { get; set; }
    }
}
