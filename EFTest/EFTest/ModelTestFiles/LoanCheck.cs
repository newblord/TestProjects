namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanCheck")]
    public partial class LoanCheck
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoanCheck()
        {
            LoanPaymentLoanCheckXrefs = new HashSet<LoanPaymentLoanCheckXref>();
        }

        [Key]
        public int LOAN_CHECK_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        [Required]
        [StringLength(1)]
        public string SEQUENCE { get; set; }

        [Required]
        [StringLength(10)]
        public string CHECK_NO { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CHECK_AMT { get; set; }

        [Column(TypeName = "date")]
        public DateTime ORIG_DUE_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime ADJUSTED_DUE_DATE { get; set; }

        [Required]
        [StringLength(1)]
        public string CHECK_STATUS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime STATUS_DATE { get; set; }

        public bool SHREDDED { get; set; }

        public virtual Loan Loan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanPaymentLoanCheckXref> LoanPaymentLoanCheckXrefs { get; set; }
    }
}
