namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DirtyDataJobRun")]
    public partial class DirtyDataJobRun
    {
        [Key]
        public int DIRTY_DATA_JOB_RUN_KEY { get; set; }

        public int JOB_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public int RECORD_COUNT { get; set; }

        public bool IS_ERROR { get; set; }

        [Required]
        [StringLength(1000)]
        public string ERROR_MESSAGE { get; set; }

        public virtual DirtyDataJob DirtyDataJob { get; set; }
    }
}
