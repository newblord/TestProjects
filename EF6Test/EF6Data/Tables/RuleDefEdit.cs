namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RuleDefEdit")]
    public partial class RuleDefEdit
    {
        [Key]
        public int RULE_DEF_EDIT_KEY { get; set; }

        public int RULE_DEF_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(128)]
        public string FIELD_NAME { get; set; }

        public string OLD_VALUE { get; set; }

        public string NEW_VALUE { get; set; }

        public virtual RuleDef RuleDef { get; set; }
    }
}
