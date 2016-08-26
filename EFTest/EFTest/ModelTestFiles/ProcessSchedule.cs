namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProcessSchedule")]
    public partial class ProcessSchedule
    {
        [Key]
        public int PROCESS_SCHEDULE_KEY { get; set; }

        public int PROCESS_CONFIG_INSTANCE_KEY { get; set; }

        [StringLength(64)]
        public string JOB_NAME { get; set; }

        public bool SUN { get; set; }

        public bool MON { get; set; }

        public bool TUES { get; set; }

        public bool WED { get; set; }

        public bool THURS { get; set; }

        public bool FRI { get; set; }

        public bool SAT { get; set; }

        public short MONTHLY_DAY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime START_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? END_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? START_TIME { get; set; }

        [StringLength(50)]
        public string TIME_ZONE { get; set; }

        public bool IS_RESTART { get; set; }

        public virtual ProcessConfigInstance ProcessConfigInstance { get; set; }
    }
}
