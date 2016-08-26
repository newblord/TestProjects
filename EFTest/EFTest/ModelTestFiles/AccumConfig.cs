namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccumConfig")]
    public partial class AccumConfig
    {
        [Key]
        public int ACCUM_CONFIG_KEY { get; set; }

        [Required]
        [StringLength(25)]
        public string SHORT_DESCR { get; set; }

        [StringLength(300)]
        public string LONG_DESCR { get; set; }

        [StringLength(500)]
        public string TASK_ACTION_RESULT_KEYS { get; set; }

        [StringLength(300)]
        public string AGENT_ACTION_KEYS { get; set; }

        [StringLength(100)]
        public string RESULT1_KEYS { get; set; }

        [StringLength(100)]
        public string RESULT2_KEYS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal ACCUM_COST { get; set; }

        public bool SHOW_IN_RI { get; set; }

        [StringLength(300)]
        public string EXCLUDE_RESULTS { get; set; }
    }
}
