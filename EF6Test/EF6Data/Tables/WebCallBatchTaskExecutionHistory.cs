namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallBatchTaskExecutionHistory")]
    public partial class WebCallBatchTaskExecutionHistory
    {
        [Key]
        public int Web_Call_BatchTask_Execution_Key { get; set; }

        public int Web_Call_BatchTask_Key { get; set; }

        [Required]
        [StringLength(4000)]
        public string CriteriaText { get; set; }

        [Required]
        [StringLength(4000)]
        public string ActionText { get; set; }

        [Required]
        [StringLength(4000)]
        public string TargetWorkItemIDs { get; set; }

        public DateTime RunDate { get; set; }

        [Required]
        [StringLength(3)]
        public string RunBy { get; set; }
    }
}
