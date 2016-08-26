namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xoei")]
    public partial class Xoei
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int oeikey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lkey { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OPEN_END_INTEREST_KEY { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_KEY { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "smallmoney")]
        public decimal PRINC_DUE { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "numeric")]
        public decimal INTEREST_ADDED { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "smalldatetime")]
        public DateTime INTEREST_DATE { get; set; }

        public int? OPEN_END_LOAN_STMT_KEY { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "smallmoney")]
        public decimal LOAN_BALANCE { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "numeric")]
        public decimal CSO_LENDER_INTEREST_ADDED { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool IS_ACH_ADJ { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool IS_ERR_ADJ { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "smallmoney")]
        public decimal CAB_FEE_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? COLLECTIONS_AMT { get; set; }
    }
}
