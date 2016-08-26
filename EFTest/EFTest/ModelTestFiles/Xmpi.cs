namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xmpi")]
    public partial class Xmpi
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mpikey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lkey { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MPAY_INTEREST_KEY { get; set; }

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

        [Key]
        [Column(Order = 8, TypeName = "smallmoney")]
        public decimal LOAN_BALANCE { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool IS_ACH_ADJ { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool IS_ERR_ADJ { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "numeric")]
        public decimal TRANS_FEE_ADDED { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "numeric")]
        public decimal CAB_INTEREST_ADDED { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool IS_DISCOUNT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? COLLECTIONS_AMT { get; set; }
    }
}
