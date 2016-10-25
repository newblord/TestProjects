namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FurtherFinanceExecutionLog")]
    public partial class FurtherFinanceExecutionLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FurtherFinanceExecutionLog()
        {
            FurtherFinanceExecutionLogDetails = new HashSet<FurtherFinanceExecutionLogDetail>();
        }

        [Key]
        public int FURTHER_FINANCE_EXECUTION_LOG_KEY { get; set; }

        public int? FURTHER_FINANCE_PARENT_OUTCOME_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        [StringLength(1)]
        public string PRODUCT_TYPE { get; set; }

        [StringLength(1)]
        public string LOAN_TYPE { get; set; }

        public DateTime? DATE_ENTERED { get; set; }

        [StringLength(3)]
        public string TELLER { get; set; }

        public int? LOAN_APPLICATION_KEY { get; set; }

        public virtual LoanApplication LoanApplication { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FurtherFinanceExecutionLogDetail> FurtherFinanceExecutionLogDetails { get; set; }
    }
}
