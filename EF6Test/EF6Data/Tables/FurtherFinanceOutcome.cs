namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FurtherFinanceOutcome")]
    public partial class FurtherFinanceOutcome
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FurtherFinanceOutcome()
        {
            FurtherFinanceExecutionLogDetails = new HashSet<FurtherFinanceExecutionLogDetail>();
            FurtherFinanceResultDetails = new HashSet<FurtherFinanceResultDetail>();
        }

        [Key]
        public int FURTHER_FINANCE_OUTCOME_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string OUTCOME_DESCRIPTION { get; set; }

        public decimal OUTCOME_APPROVAL_PCT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FurtherFinanceExecutionLogDetail> FurtherFinanceExecutionLogDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FurtherFinanceResultDetail> FurtherFinanceResultDetails { get; set; }
    }
}
