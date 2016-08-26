namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RuleDefSetDetail")]
    public partial class RuleDefSetDetail
    {
        [Key]
        public int RULE_DEF_SET_DETAIL_KEY { get; set; }

        public int RULE_DEF_SET_KEY { get; set; }

        public int RULE_DEF_KEY { get; set; }

        public int PRIORITY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public virtual RuleDef RuleDef { get; set; }

        public virtual RuleDefSet RuleDefSet { get; set; }
    }
}
