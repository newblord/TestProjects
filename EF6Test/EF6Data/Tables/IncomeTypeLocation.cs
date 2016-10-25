namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IncomeTypeLocation")]
    public partial class IncomeTypeLocation
    {
        [Key]
        public int INCOME_TYPE_LOC_KEY { get; set; }

        public int INCOME_TYPE_KEY { get; set; }

        public short LOCATION { get; set; }

        public bool IS_ACTIVE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime LAST_UPDATED_DATE { get; set; }

        [Required]
        [StringLength(3)]
        public string LAST_UPDATED_BY { get; set; }

        [Required]
        [StringLength(200)]
        public string ENUM_LIST_FOR_INCOME_MAINT_REQUIRED_FIELDS { get; set; }

        public virtual Company Company { get; set; }

        public virtual IncomeType IncomeType { get; set; }
    }
}
