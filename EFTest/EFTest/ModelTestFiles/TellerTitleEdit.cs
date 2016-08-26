namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TellerTitleEdit")]
    public partial class TellerTitleEdit
    {
        [Key]
        public int TITLE_EDIT_KEY { get; set; }

        public int TITLE_KEY { get; set; }

        [Required]
        [StringLength(63)]
        public string MODIFICATION { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public virtual TellerTitle TellerTitle { get; set; }
    }
}
