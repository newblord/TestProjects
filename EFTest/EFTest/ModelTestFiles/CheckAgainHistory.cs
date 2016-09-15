namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CheckAgainHistory")]
    public partial class CheckAgainHistory
    {
        [Key]
        public int CHECKAGAINHISTORY_KEY { get; set; }

        public int CHECKAGAIN_KEY { get; set; }

        [Required]
        [StringLength(1)]
        public string STATUS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public virtual CheckAgain CheckAgain { get; set; }
    }
}
