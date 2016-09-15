namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OpenEndRecalcInterestAdj")]
    public partial class OpenEndRecalcInterestAdj
    {
        [Key]
        public int OPEN_END_RECALC_INTEREST_ADJ_KEY { get; set; }

        public int OPEN_END_INTEREST_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Column(TypeName = "date")]
        public DateTime? INTEREST_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime C_INTEREST_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal INTEREST_ADDED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal C_INTEREST_ADDED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CAB_INTEREST_ADDED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal C_CAB_INTEREST_ADDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINC_DUE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PRINC_DUE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_LOAN_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CAB_FEE_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_CAB_FEE_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal COLLECTIONS_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_COLLECTIONS_AMT { get; set; }
    }
}
