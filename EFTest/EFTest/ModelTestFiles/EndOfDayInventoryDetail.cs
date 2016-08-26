namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EndOfDayInventoryDetail")]
    public partial class EndOfDayInventoryDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EODR_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal ONHAND_AMT { get; set; }

        public bool DEFAULTED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal RI_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CAB_FEE_RECEIVABLE_AMT { get; set; }
    }
}
