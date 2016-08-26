namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IdentificationTypeRule")]
    public partial class IdentificationTypeRule
    {
        [Key]
        public int IDENTIFICATION_TYPE_RULE_KEY { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public bool IS_ACTIVE { get; set; }

        public short SORT_ORDER { get; set; }

        [Required]
        [StringLength(250)]
        public string RULE_DEFINITION { get; set; }

        [Required]
        [StringLength(500)]
        public string RULE_DESCRIPTION { get; set; }

        [Required]
        [StringLength(500)]
        public string RULE_MESSAGE { get; set; }

        [StringLength(250)]
        public string RULE_DIRECTIVES { get; set; }
    }
}
