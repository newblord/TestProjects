namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IatDialerResult
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HostCode { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public int Ris_Task_id { get; set; }

        [StringLength(60)]
        public string CURO_Note { get; set; }

        public int? TASK_ACTION_RESULT_KEY { get; set; }

        public int? AGENT_ACTION_KEY { get; set; }

        public int? AGENT_RESULT_KEY1 { get; set; }
    }
}
