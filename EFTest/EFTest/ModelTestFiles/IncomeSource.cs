namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IncomeSource")]
    public partial class IncomeSource
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IncomeSource()
        {
            CustomerEmployers = new HashSet<CustomerEmployer>();
            LoanApplicationEmployers = new HashSet<LoanApplicationEmployer>();
        }

        [Key]
        public int INCOME_SOURCE_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRIPTION { get; set; }

        public bool IS_ACTIVE { get; set; }

        public int INCOME_TYPE_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime LAST_UPDATED_DATE { get; set; }

        [Required]
        [StringLength(3)]
        public string LAST_UPDATED_BY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerEmployer> CustomerEmployers { get; set; }

        public virtual IncomeType IncomeType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplicationEmployer> LoanApplicationEmployers { get; set; }
    }
}
