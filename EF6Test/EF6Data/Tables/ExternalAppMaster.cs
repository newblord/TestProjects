namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExternalAppMaster")]
    public partial class ExternalAppMaster
    {
        [Key]
        public int EXTERNAL_APP_MASTER_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string TASK_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string SERVER_NAME { get; set; }

        [Required]
        [StringLength(1)]
        public string DTS_OR_EXE { get; set; }

        [Required]
        [StringLength(255)]
        public string RUN_FILE { get; set; }

        [Required]
        [StringLength(255)]
        public string RUN_START_FOLDER { get; set; }

        [Required]
        [StringLength(255)]
        public string DESCRIPTION { get; set; }

        [Required]
        [StringLength(64)]
        public string STATUS_DESC { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NEXT_RUN_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LAST_RUN_DATE { get; set; }

        [Required]
        [StringLength(10)]
        public string LAST_RESULT { get; set; }
    }
}
