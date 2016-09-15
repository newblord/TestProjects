namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AutoReportSchedule")]
    public partial class AutoReportSchedule
    {
        [Key]
        public int AUTO_REPORT_SCHEDULE_KEY { get; set; }

        public int AUTO_REPORT_KEY { get; set; }

        public int AUTO_REPORT_RUN_SCHEDULE_KEY { get; set; }

        public virtual AutoReport AutoReport { get; set; }

        public virtual AutoReportRunSchedule AutoReportRunSchedule { get; set; }
    }
}
