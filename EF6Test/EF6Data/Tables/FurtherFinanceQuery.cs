namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FurtherFinanceQuery")]
    public partial class FurtherFinanceQuery
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FurtherFinanceQuery()
        {
            FurtherFinanceExecutionLogDetails = new HashSet<FurtherFinanceExecutionLogDetail>();
            FurtherFinanceResultDetails = new HashSet<FurtherFinanceResultDetail>();
        }

        [Key]
        public int FURTHER_FINANCE_QUERY_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string QUERY_NAME { get; set; }

        [Required]
        public string DESCRIPTION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FurtherFinanceExecutionLogDetail> FurtherFinanceExecutionLogDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FurtherFinanceResultDetail> FurtherFinanceResultDetails { get; set; }
    }
}
