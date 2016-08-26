namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IncomeVerifyMethodLocation")]
    public partial class IncomeVerifyMethodLocation
    {
        [Key]
        public int INCOME_VERIFY_METHOD_LOC_KEY { get; set; }

        public int INCOME_VERIFY_METHOD_KEY { get; set; }

        public short LOCATION { get; set; }

        public bool IS_ACTIVE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime LAST_UPDATED_DATE { get; set; }

        [Required]
        [StringLength(3)]
        public string LAST_UPDATED_BY { get; set; }

        public virtual Company Company { get; set; }

        public virtual IncomeVerifyMethod IncomeVerifyMethod { get; set; }
    }
}
