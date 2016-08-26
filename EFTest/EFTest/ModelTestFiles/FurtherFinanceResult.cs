namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FurtherFinanceResult")]
    public partial class FurtherFinanceResult
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FurtherFinanceResult()
        {
            FurtherFinanceResultDetails = new HashSet<FurtherFinanceResultDetail>();
        }

        [Key]
        public int FURTHER_FINANCE_RESULT_KEY { get; set; }

        public int? FURTHER_FINANCE_PARENT_OUTCOME_KEY { get; set; }

        public int? LOAN_APPLICATION_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public DateTime? DATE_ENTERED { get; set; }

        [StringLength(3)]
        public string TELLER { get; set; }

        [StringLength(1)]
        public string PRODUCT_TYPE_SELECTED { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual LoanApplication LoanApplication { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FurtherFinanceResultDetail> FurtherFinanceResultDetails { get; set; }
    }
}
