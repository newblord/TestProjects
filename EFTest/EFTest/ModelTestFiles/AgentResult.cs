namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AgentResult")]
    public partial class AgentResult
    {
        [Key]
        public int AGENT_RESULT_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string LONG_DESCR { get; set; }

        [Required]
        [StringLength(20)]
        public string SHORT_DESCR { get; set; }

        public byte RESULT_LEVEL { get; set; }

        public byte SCREEN_POP { get; set; }
    }
}
