namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FurtherFinanceJobType")]
    public partial class FurtherFinanceJobType
    {
        [Key]
        public int FURTHER_FINANCE_JOB_TYPE_KEY { get; set; }

        public int INCOME_JOB_TYPE_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INCREASE1 { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INCREASE2 { get; set; }

        public virtual IncomeJobType IncomeJobType { get; set; }
    }
}
