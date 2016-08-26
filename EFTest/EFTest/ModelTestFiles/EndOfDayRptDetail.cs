namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EndOfDayRptDetail")]
    public partial class EndOfDayRptDetail
    {
        [Key]
        public int EODR_DET_KEY { get; set; }

        public int EODR_KEY { get; set; }

        public short ORDER_NUM { get; set; }

        [StringLength(300)]
        public string EODR_DESC { get; set; }

        [StringLength(6)]
        public string ACCOUNT1 { get; set; }

        [StringLength(6)]
        public string QTY1 { get; set; }

        [StringLength(14)]
        public string AMOUNT1 { get; set; }

        [StringLength(15)]
        public string FEE1 { get; set; }

        [StringLength(6)]
        public string ACCOUNT2 { get; set; }

        [StringLength(6)]
        public string QTY2 { get; set; }

        [StringLength(14)]
        public string AMOUNT2 { get; set; }

        [StringLength(15)]
        public string FEE2 { get; set; }

        public bool HEADER { get; set; }

        public bool FOOTER { get; set; }

        public virtual EndOfDayRpt EndOfDayRpt { get; set; }
    }
}
