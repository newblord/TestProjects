namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaskActionResultXref")]
    public partial class TaskActionResultXref
    {
        [Key]
        public int TASK_ACTION_RESULT_XREF_KEY { get; set; }

        public int TASK_ACTION_RESULT_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? UPDATE_DATE { get; set; }

        [StringLength(3)]
        public string UPDATE_TELLER { get; set; }

        [Required]
        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        [Required]
        [StringLength(20)]
        public string CODE { get; set; }

        public virtual TaskActionResult TaskActionResult { get; set; }
    }
}
