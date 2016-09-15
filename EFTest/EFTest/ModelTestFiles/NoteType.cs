namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NoteType")]
    public partial class NoteType
    {
        [Key]
        public int NOTE_TYPE_KEY { get; set; }

        public int NOTE_TYPE_VALUE { get; set; }

        [Required]
        [StringLength(30)]
        public string DESCRIPTION { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }
    }
}
