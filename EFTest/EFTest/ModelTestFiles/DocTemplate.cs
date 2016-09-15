namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocTemplate")]
    public partial class DocTemplate
    {
        [Key]
        public int DOCTEMPLATE_KEY { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string DOC_DATA { get; set; }

        [Required]
        [StringLength(255)]
        public string DOC_NAME { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(1)]
        public string DOC_FORMAT { get; set; }
    }
}
