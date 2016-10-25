namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MPayInterest")]
    public partial class MPayInterest
    {
        [Key]
        public int MPAY_INTEREST_KEY { get; set; }

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

        public bool IS_ACH_ADJ { get; set; }

        public bool IS_ERR_ADJ { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TRANS_FEE_ADDED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CAB_INTEREST_ADDED { get; set; }

        public bool IS_DISCOUNT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? COLLECTIONS_AMT { get; set; }

        public virtual Loan Loan { get; set; }
    }
}
