namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MPayAmortDueDateChange")]
    public partial class MPayAmortDueDateChange
    {
        [Key]
        public int MPAY_AMORT_DUE_DATE_CHANGE_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public int MPAY_AMORT_KEY { get; set; }

        [Column(TypeName = "date")]
        public DateTime ADJUSTED_DUE_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public bool IS_DELETED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_DELETED { get; set; }

        [StringLength(3)]
        public string DELETED_BY { get; set; }

        public virtual Loan Loan { get; set; }

        public virtual MPayAmort MPayAmort { get; set; }
    }
}
