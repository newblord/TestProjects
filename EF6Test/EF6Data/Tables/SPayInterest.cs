namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SPayInterest")]
    public partial class SPayInterest
    {
        [Key]
        public int SPAY_INTEREST_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINC_DUE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal INTEREST_ADDED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime INTEREST_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_BALANCE { get; set; }

        public bool IS_ERR_ADJ { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_FEE_DUE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CAB_INTEREST_ADDED { get; set; }

        public bool IS_MIN_INTEREST_ADJUSTMENT { get; set; }

        public virtual Loan Loan { get; set; }
    }
}
