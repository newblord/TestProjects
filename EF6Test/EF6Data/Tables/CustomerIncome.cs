namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerIncome")]
    public partial class CustomerIncome
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerIncome()
        {
            LoanIncomes = new HashSet<LoanIncome>();
        }

        [Key]
        public int CUSTOMER_INCOME_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Required]
        [StringLength(1)]
        public string AMOUNT_TYPE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INCOME_AMOUNT { get; set; }

        public int? INCOME_VERIFY_METHOD_KEY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATE_VERIFIED { get; set; }

        public bool IS_DELETED { get; set; }

        [Required]
        [StringLength(3)]
        public string DELETED_TELLER { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATE_DELETED { get; set; }

        public int CUSTOMER_EMPLOYER_KEY { get; set; }

        [Required]
        [StringLength(1)]
        public string AMOUNT_CYCLE { get; set; }

        public bool IS_ACTIVE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_INACTIVE { get; set; }

        [Required]
        [StringLength(3)]
        public string INACTIVE_TELLER { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual CustomerEmployer CustomerEmployer { get; set; }

        public virtual IncomeVerifyMethod IncomeVerifyMethod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanIncome> LoanIncomes { get; set; }
    }
}
