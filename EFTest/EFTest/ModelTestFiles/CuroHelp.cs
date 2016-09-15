namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CuroHelp")]
    public partial class CuroHelp
    {
        [Key]
        public int CUROHELP_KEY { get; set; }

        [Required]
        [StringLength(30)]
        public string FORM_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string CONTROL_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string HELP_TITLE { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string HELP_TEXT { get; set; }

        [Required]
        [StringLength(500)]
        public string TOOLTIP_TEXT { get; set; }
    }
}
