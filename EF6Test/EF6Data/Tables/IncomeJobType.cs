namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IncomeJobType")]
    public partial class IncomeJobType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IncomeJobType()
        {
            CustomerEmployers = new HashSet<CustomerEmployer>();
            FurtherFinanceJobTypes = new HashSet<FurtherFinanceJobType>();
            LoanApplicationEmployers = new HashSet<LoanApplicationEmployer>();
        }

        [Key]
        public int INCOME_JOB_TYPE_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string DESCRIPTION { get; set; }

        public bool IS_ACTIVE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime LAST_UPDATED_DATE { get; set; }

        [Required]
        [StringLength(3)]
        public string LAST_UPDATED_BY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal WAGE_LIMIT { get; set; }

        public short DAYS_TO_REREQUEST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerEmployer> CustomerEmployers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FurtherFinanceJobType> FurtherFinanceJobTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplicationEmployer> LoanApplicationEmployers { get; set; }
    }
}
