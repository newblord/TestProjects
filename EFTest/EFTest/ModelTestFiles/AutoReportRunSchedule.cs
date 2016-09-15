namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AutoReportRunSchedule")]
    public partial class AutoReportRunSchedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AutoReportRunSchedule()
        {
            AutoReportSchedules = new HashSet<AutoReportSchedule>();
        }

        [Key]
        public int AUTO_REPORT_RUN_SCHEDULE_KEY { get; set; }

        public int RUN_TIME { get; set; }

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

        [StringLength(50)]
        public string JOB_NAME { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? START_TIME { get; set; }

        public bool? HOURLY { get; set; }

        public int? EVERY_X_MINUTES { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? END_TIME { get; set; }

        [StringLength(50)]
        public string TIME_ZONE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutoReportSchedule> AutoReportSchedules { get; set; }
    }
}
