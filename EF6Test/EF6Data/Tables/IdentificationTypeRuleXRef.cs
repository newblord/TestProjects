namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IdentificationTypeRuleXRef")]
    public partial class IdentificationTypeRuleXRef
    {
        [Key]
        public int IDENTIFICATION_TYPE_RULE_XREF_KEY { get; set; }

        public int IDENTIFICATION_TYPE_RULE_KEY { get; set; }

        public int IDENTIFICATION_TYPE_KEY { get; set; }

        [Required]
        [StringLength(2)]
        public string STATE { get; set; }
    }
}
