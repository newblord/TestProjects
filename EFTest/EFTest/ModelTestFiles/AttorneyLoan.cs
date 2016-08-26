namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AttorneyLoan")]
    public partial class AttorneyLoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AttorneyLoan()
        {
            AttorneyPayments = new HashSet<AttorneyPayment>();
        }

        [Key]
        public int ATTORNEY_LOAN_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public int? LOAN_KEY { get; set; }

        public int? CASHED_CHECK_KEY { get; set; }

        public short ATTORNEY_KEY { get; set; }

        public short COMMISSION_PCT { get; set; }

        public bool IS_ACTIVE { get; set; }

        public virtual Attorney Attorney { get; set; }

        public virtual CashedCheck CashedCheck { get; set; }

        public virtual Loan Loan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttorneyPayment> AttorneyPayments { get; set; }
    }
}
