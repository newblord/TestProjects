namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RuleDefSetDetailEdit")]
    public partial class RuleDefSetDetailEdit
    {
        [Key]
        public int RULE_DEF_SET_DETAIL_EDIT_KEY { get; set; }

        public int RULE_DEF_SET_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(1)]
        public string ACTION_TYPE { get; set; }

        [Required]
        [StringLength(128)]
        public string FIELD_NAME { get; set; }

        [StringLength(10)]
        public string OLD_VALUE { get; set; }

        [StringLength(10)]
        public string NEW_VALUE { get; set; }

        public virtual RuleDefSet RuleDefSet { get; set; }
    }
}
